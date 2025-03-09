using AuthPermissions.AspNetCore.GetDataKeyCode;
using AuthPermissions.BaseCode.CommonCode;
using AuthPermissions.BaseCode.DataLayer.EfCode;
using FBT.ShareModels.Commons;
using FBT.ShareModels.Entities;
using FBT.ShareModels.WMS;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FBT.Migrations
{
    public class IdentityForWMSContext : IdentityDbContext<ApplicationUser>
    {

        public IdentityForWMSContext(DbContextOptions<IdentityForWMSContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("wms");
        }

    }
}