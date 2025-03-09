using AuthPermissions.AspNetCore.GetDataKeyCode;
using AuthPermissions.BaseCode.CommonCode;
using AuthPermissions.BaseCode.DataLayer.EfCode;
using FBT.ShareModels.Commons;
using FBT.ShareModels.Entities;
using FBT.ShareModels.WMS;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FBT.Migrations
{
    public class ApplicationDbContext : DbContext, IDataKeyFilterReadOnly
    {
        public string DataKey { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IGetDataKeyFromUser dataKeyFilter)
            : base(options)
        {
            // The DataKey is null when: no one is logged in, its a background service, or user hasn't got an assigned tenant
            // In these cases its best to set the data key that doesn't match any possible DataKey 
            DataKey = dataKeyFilter?.DataKey ?? "stop any user without a DataKey to access the data";
        }

        public DbSet<CompanyTenant> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ChannelMaster> ChannelMasters { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<SalesData> SalesData { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStatus> ProductStatuses { get; set; }
        public DbSet<SystemClassCompany> SystemClassCompanies { get; set; }
        public DbSet<ApiCode> ApiCodes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<UserVendor> UserVendors { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ShippingCountry> ShippingCountries { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        public DbSet<CountryMaster> CountryMasters { get; set; }
        public DbSet<CurrencyPairSetting> CurrencyPairSettings { get; set; }
        public DbSet<ProductBundle> ProductBundles { get; set; }
        public DbSet<PreSetProductSetting> PreSetProductSettings { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ArrivalInstruction> ArrivalInstructions { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<TaskChatHistory> TaskChatHistories { get; set; }
        public DbSet<AttachedItem> AttachedItems { get; set; }
        public DbSet<AttachedItemChannel> AttachedItemChannels { get; set; }
        public DbSet<AttachedItemProductType> AttachedItemProductTypes { get; set; }
        public DbSet<AttachedItemCategory> AttachedItemCategories { get; set; }
        public DbSet<AttachedItemDetail> AttachedItemDetails { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<BatchCalendar> BatchCalendars { get; set; }
        public DbSet<BatchSchedule> BatchSchedules { get; set; }
        public DbSet<TaskSchedule> TaskSchedules { get; set; }
        public DbSet<TempShopifyOrder> TempShopifyOrders { get; set; }
        public DbSet<TempShopifyOrderProduct> TempShopifyOrderProducts { get; set; }
        public DbSet<OrderDispatch> OrderDispatches { get; set; }
        public DbSet<OrderDispatchProduct> OrderDispatchProducts { get; set; }
        public DbSet<ForecastedSalesData> ForecastedSalesDatas { get; set; }
        public DbSet<SystemMaxPKNo> SystemMaxPKNos { get; set; }
        public DbSet<ProductJanCode> ProductJanCodes { get; set; }
        public DbSet<FdaRegistration> FdaRegistrations { get; set; }
        public DbSet<InventTransfer> InventTransfers { get; set; }
        public DbSet<InventTransferLine> InventTransferLines { get; set; }
        public DbSet<DeliveryCompany> DeliveryCompanies { get; set; }
        public DbSet<CourierApi> CourierApis { get; set; }
        public DbSet<ShippingRule> ShippingRules { get; set; }
        public DbSet<MstSystemClass> MstSystemClasses { get; set; }
		public DbSet<ApiLog> ApiLogs { get; set; }
		public DbSet<InventAdjustment> InventAdjustments { get; set; }
        public DbSet<InventAdjustmentLine> InventAdjustmentLines { get; set; }
        public DbSet<InventStockTake> InventStockTakes { get; set; }
        public DbSet<InventStockTakeLine> InventStockTakeLines { get; set; }
        public DbSet<InventStockTakeRecording> InventStockTakeRecordings { get; set; }
        public DbSet<InventStockTakeRecordingLine> InventStockTakeRecordingLines { get; set; }
        public DbSet<ImageStorage>  ImageStorages { get; set; }
        public DbSet<InventBundle> InventBundles { get; set; }
        public DbSet<InventBundleLine> InventBundleLines { get; set; }

        #region 
        public DbSet<MstUserSetting> MstUserSettings { get; set; }
        public DbSet<RefreshTokens> RefreshTokens { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<PermissionsTenant> PermissionsTenants { get; set; }
        public DbSet<RoleToPermission> RoleToPermissions { get; set; }
        public DbSet<RoleToPermissionTenant> RoleToPermissionTenants { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Batches> BatchesWms { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UserToTenant> UserToTenants { get; set; }

        public DbSet<WarehouseTran> WarehouseTrans { get; set; }
        public DbSet<WarehousePutAway> WarehousePutAways { get; set; }
        public DbSet<WarehousePutAwayLine> WarehousePutAwayLines { get; set; }
        public DbSet<WarehousePutAwayStaging> WarehousePutAwayStagings { get; set; }
        public DbSet<WarehouseReceiptOrder> WarehouseReceiptOrders { get; set; }
        public DbSet<WarehouseReceiptOrderLine> WarehouseReceiptOrderLines { get; set; }
        public DbSet<WarehouseReceiptStaging> WarehouseReceiptStagings { get; set; }
        public DbSet<NumberSequences> SequencesNumber { get; set; }
        public DbSet<LogTime> LogTimes { get; set; }

        #region Outbound
        public DbSet<ReturnOrder> ReturnOrders { get; set; }
        public DbSet<ReturnOrderLine> ReturnOrderLines { get; set; }
        public DbSet<ShippingBox> ShippingBoxes { get; set; }
        public DbSet<ShippingCarrier> ShippingCarriers { get; set; }
        public DbSet<WarehousePickingLine> WarehousePickingLines { get; set; }
        public DbSet<WarehousePickingList> WarehousePickingLists { get; set; }
        public DbSet<WarehousePickingStaging> WarehousePickingStagings { get; set; }
        public DbSet<WarehouseShipment> WarehouseShipments { get; set; }
        public DbSet<WarehouseShipmentLine> WarehouseShipmentLines { get; set; }
        public DbSet<WarehouseParameter> WarehouseParameters { get; set; }
        #endregion
        #endregion



        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.MarkWithDataKeyIfNeeded(DataKey);
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.MarkWithDataKeyIfNeeded(DataKey);
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Check if the entity type has a namespace
                if (!string.IsNullOrEmpty(entityType.ClrType.Namespace))
                {
                    if (entityType.ClrType.Namespace.Contains("WMS"))
                    {
                        entityType.SetSchema("wms");
                        continue;
                    }
                }

                // Create index for DataKey field if it exists
                if (entityType.FindProperty("DataKey") != null)
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .HasIndex(nameof(IDataKeyFilter.DataKey))
                        .HasDatabaseName($"IX_{entityType.GetTableName()}_DataKey");
                }
            }

            modelBuilder.Entity<CourierApi>()
              .HasKey(m => new { m.CompanyId, m.CourierCd, m.ApiParam });

        }

    }
}