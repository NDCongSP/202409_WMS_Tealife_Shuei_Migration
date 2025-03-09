using AuthPermissions;
using AuthPermissions.AdminCode;
using AuthPermissions.AspNetCore;
using AuthPermissions.AspNetCore.Services;
using AuthPermissions.BaseCode;
using AuthPermissions.BaseCode.SetupCode;
using FBT.Migration;
using FBT.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var _configuration = builder.Configuration;
var _env = builder.Environment;

builder.Services.AddHttpContextAccessor();

var connectionString = _configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        connectionString, dbOptions =>
    dbOptions.MigrationsHistoryTable("__AppDbContextMigrationHistory")));

builder.Services.AddDbContext<IdentityForOMSContext>(options =>
    options.UseSqlServer(
        connectionString));
builder.Services.AddDbContext<IdentityForWMSContext>(options =>
    options.UseSqlServer(
        connectionString));

builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.RegisterAuthPermissions<FBTPermissions>(options =>
{
    options.TenantType = TenantTypes.HierarchicalTenant;
    options.LinkToTenantType = LinkToTenantTypes.OnlyAppUsers;
    options.EncryptionKey = _configuration[nameof(AuthPermissionsOptions.EncryptionKey)];
    options.PathToFolderToLock = _env.WebRootPath;
})
//NOTE: This uses the same database as the individual accounts DB
.UsingEfCoreSqlServer(connectionString)
.IndividualAccountsAuthentication()
.AddSuperUserToIndividualAccounts()

.SetupAspNetCoreAndDatabase(options =>
{
});

// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
