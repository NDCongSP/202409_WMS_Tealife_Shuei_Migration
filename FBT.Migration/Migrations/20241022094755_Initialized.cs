using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Initialized : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "wms");

            migrationBuilder.CreateTable(
                name: "ApiCodes",
                schema: "dbo",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiCodes", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ArrivalInstructions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ScheduledArrivalNumber = table.Column<int>(type: "int", nullable: false),
                    ScheduledArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrivalInstructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                schema: "dbo",
                columns: table => new
                {
                    BatchId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartupStatus = table.Column<bool>(type: "bit", nullable: false),
                    Args = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ExpirationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatchSchedules",
                schema: "dbo",
                columns: table => new
                {
                    BatchScheduleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<bool>(type: "bit", nullable: false),
                    IsFailed = table.Column<bool>(type: "bit", nullable: false),
                    IsStopped = table.Column<bool>(type: "bit", nullable: false),
                    RequestId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBatchInRequest = table.Column<bool>(type: "bit", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchSchedules", x => x.BatchScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "Bins",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChannelMasters",
                schema: "dbo",
                columns: table => new
                {
                    ChannelMasterCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChannelMasterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelMasters", x => x.ChannelMasterCode);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "dbo",
                columns: table => new
                {
                    CompanyTenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AuthPTenantId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyTenantId);
                });

            migrationBuilder.CreateTable(
                name: "CountryMasters",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryIsoNumeric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryIso2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryIso3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryNameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "dbo",
                columns: table => new
                {
                    CurrencyCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisplayCurrency = table.Column<bool>(type: "bit", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyCode);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyPairSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCodeFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyCodeTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateDecimalPlaces = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyPairSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyCodeFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyCodeTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    AcquisitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogTime",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EslapseTime = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MstUserSettings",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstUserSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumberSequences",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JournalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SequenceLength = table.Column<int>(type: "int", nullable: true),
                    CurrentSequenceNo = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberSequences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDispatches",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DeliveryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketDeliveryNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DispatchStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCutOff = table.Column<bool>(type: "bit", nullable: false),
                    CutoffDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CutoffId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMarketShipped = table.Column<bool>(type: "bit", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDispatches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderChannel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionsTenants",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionsTenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBundles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleProductBundleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductBundleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BundlePriceRatio = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChildProductStatus = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBundles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductJanCodes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JanCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductJanCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatuses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductStocks",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BinCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Expried = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                schema: "wms",
                columns: table => new
                {
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activated = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshToken);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrderLines",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrderLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnOrders",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonInCharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleToPermissions",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermisionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleToPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleToPermissionTenants",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionTenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionTenantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionTenantDesciption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleToPermissionTenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesData",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderYear = table.Column<int>(type: "int", nullable: false),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    CostOfSales = table.Column<double>(type: "float", nullable: false),
                    Sales = table.Column<double>(type: "float", nullable: false),
                    Profit = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepeatPurchase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingBoxes",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoxName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    MaxWeight = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingBoxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingCarriers",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingCarrierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingCarriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingCountries",
                schema: "dbo",
                columns: table => new
                {
                    CountryCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingCountries", x => x.CountryCode);
                });

            migrationBuilder.CreateTable(
                name: "StockInOutItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    ItemCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInOutItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockInOuts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InOutCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockLocations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockTypes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SupplierId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemClassCompanies",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    LargeClassCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallClassCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LargeClassCodeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallClassCodeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numeric1 = table.Column<int>(type: "int", nullable: true),
                    Numeric2 = table.Column<double>(type: "float", nullable: true),
                    Date1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Text1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemClassCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemMaxPKNos",
                schema: "dbo",
                columns: table => new
                {
                    ObjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaxNo = table.Column<int>(type: "int", nullable: false),
                    Digit = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemMaxPKNos", x => x.ObjectCode);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Assignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskType = table.Column<int>(type: "int", nullable: false),
                    TaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FDALink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskSchedules",
                schema: "dbo",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    MarketplaceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsFailed = table.Column<bool>(type: "bit", nullable: false),
                    IsStopped = table.Column<bool>(type: "bit", nullable: false),
                    RequestId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBatchInRequest = table.Column<bool>(type: "bit", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskSchedules", x => x.ScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "TempShopifyOrderProducts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grams = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalDiscount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VariantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempShopifyOrderProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TempShopifyOrders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinancialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FulfillmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gateway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalDiscounts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentmentCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempShopifyOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPLWarehouses",
                schema: "dbo",
                columns: table => new
                {
                    WarehouseCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WarehouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPLWarehouses", x => x.WarehouseCode);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageLength = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserToTenant",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToTenant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserVendors",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVendors", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOfficePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOfficeFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JamCharge = table.Column<double>(type: "float", nullable: true),
                    BillingDate = table.Column<int>(type: "int", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePickingLines",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickQty = table.Column<double>(type: "float", nullable: true),
                    ActualQty = table.Column<double>(type: "float", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePickingLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePickingList",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonInCharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    EstimatedShipDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePickingList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePickingStaging",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PickNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickQty = table.Column<double>(type: "float", nullable: true),
                    ActualQty = table.Column<double>(type: "float", nullable: true),
                    ShipmentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShipmentLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePickingStaging", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePutAwayLines",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PutAwayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    JournalQty = table.Column<double>(type: "float", nullable: true),
                    TransQty = table.Column<double>(type: "float", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePutAwayLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePutAways",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PutAwayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    TransDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DocumentDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DocumentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PostedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePutAways", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePutAwayStaging",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PutAwayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JournalQty = table.Column<double>(type: "float", nullable: true),
                    TransQty = table.Column<double>(type: "float", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PutAwayLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePutAwayStaging", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseReceiptOrder",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ArrivalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    ScheduledArrivalNumber = table.Column<int>(type: "int", nullable: true),
                    DocumentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    PersonInCharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseReceiptOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseReceiptOrderLine",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQty = table.Column<double>(type: "float", nullable: true),
                    TransQty = table.Column<double>(type: "float", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Putaway = table.Column<bool>(type: "bit", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseReceiptOrderLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseReceiptStaging",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    OrderQty = table.Column<double>(type: "float", nullable: true),
                    TransQty = table.Column<double>(type: "float", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ReceiptLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseReceiptStaging", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseShipmentLines",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: true),
                    ShipmentQty = table.Column<double>(type: "float", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PackedQty = table.Column<double>(type: "float", nullable: true),
                    PackedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseShipmentLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseShipments",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipmentNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanShipDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PersonInCharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PickingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseShipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseTrans",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    DatePhysical = table.Column<DateOnly>(type: "date", nullable: true),
                    TransType = table.Column<int>(type: "int", nullable: false),
                    TransNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusIssue = table.Column<int>(type: "int", nullable: true),
                    StatusReceipt = table.Column<int>(type: "int", nullable: true),
                    TransId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PutAwayNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseTrans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseUserSettings",
                schema: "dbo",
                columns: table => new
                {
                    WarehouseUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseUserSettings", x => x.WarehouseUserId);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                schema: "dbo",
                columns: table => new
                {
                    ChannelCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ChannelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelMasterCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChannelMasterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillCalcType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.ChannelCode);
                    table.ForeignKey(
                        name: "FK_Channels_ChannelMasters_ChannelMasterCode",
                        column: x => x.ChannelMasterCode,
                        principalSchema: "dbo",
                        principalTable: "ChannelMasters",
                        principalColumn: "ChannelMasterCode");
                });

            migrationBuilder.CreateTable(
                name: "OrderDispatchProducts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DispatchHeaderId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DeliveryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineNo = table.Column<int>(type: "int", nullable: true),
                    ProductSku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippedQty = table.Column<int>(type: "int", nullable: true),
                    MarketShippedQty = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    DeclaredValue = table.Column<double>(type: "float", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDispatchProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDispatchProducts_OrderDispatches_DispatchHeaderId",
                        column: x => x.DispatchHeaderId,
                        principalSchema: "dbo",
                        principalTable: "OrderDispatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageAttachProducts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AttachProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageAttachProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageAttachProducts_Packages_PackageId",
                        column: x => x.PackageId,
                        principalSchema: "dbo",
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ProductShortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    SaleProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductEname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductIname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockAvailableQuanitty = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JanCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Net = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Length = table.Column<double>(type: "float", nullable: true),
                    Depth = table.Column<double>(type: "float", nullable: true),
                    BaseCost = table.Column<double>(type: "float", nullable: true),
                    BaseCostOther = table.Column<double>(type: "float", nullable: true),
                    RegularPrice = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatus = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventoryMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingLimitDays = table.Column<int>(type: "int", nullable: false),
                    FromApplyPreBundles = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToApplyPreBundles = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockReceiptProcessInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockThreshold = table.Column<int>(type: "int", nullable: true),
                    IndividuallyShippedItem = table.Column<bool>(type: "bit", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskChatHistories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    ChatContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskChatHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskChatHistories_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "dbo",
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: true),
                    HandlingCharge = table.Column<double>(type: "float", nullable: true),
                    Giftvoucher = table.Column<double>(type: "float", nullable: true),
                    Point = table.Column<double>(type: "float", nullable: true),
                    Shipping = table.Column<double>(type: "float", nullable: true),
                    CodCharge = table.Column<double>(type: "float", nullable: true),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true),
                    OtherDiscount = table.Column<double>(type: "float", nullable: true),
                    TaxAmount = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDeliveryCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoldJudgmentMemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnHoldStatus = table.Column<int>(type: "int", nullable: false),
                    SubscriptionStatus = table.Column<int>(type: "int", nullable: false),
                    HadCheckAttachItem = table.Column<int>(type: "int", nullable: false),
                    InternalRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeltaData = table.Column<bool>(type: "bit", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Channels_ChannelCode",
                        column: x => x.ChannelCode,
                        principalSchema: "dbo",
                        principalTable: "Channels",
                        principalColumn: "ChannelCode");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineNo = table.Column<int>(type: "int", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    PurchaseUnitPrice = table.Column<double>(type: "float", nullable: true),
                    DeclaredValue = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnQuantity = table.Column<int>(type: "int", nullable: true),
                    ParentItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderReturnItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnQuantity = table.Column<int>(type: "int", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderReturnItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderReturnItems_Orders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiCodes_DataKey",
                schema: "dbo",
                table: "ApiCodes",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ArrivalInstructions_DataKey",
                schema: "dbo",
                table: "ArrivalInstructions",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DataKey",
                schema: "dbo",
                table: "Categories",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ChannelMasters_DataKey",
                schema: "dbo",
                table: "ChannelMasters",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Channels_ChannelMasterCode",
                schema: "dbo",
                table: "Channels",
                column: "ChannelMasterCode");

            migrationBuilder.CreateIndex(
                name: "IX_Channels_DataKey",
                schema: "dbo",
                table: "Channels",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DataKey",
                schema: "dbo",
                table: "Companies",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_CountryMasters_DataKey",
                schema: "dbo",
                table: "CountryMasters",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_DataKey",
                schema: "dbo",
                table: "Currencies",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyPairSettings_DataKey",
                schema: "dbo",
                table: "CurrencyPairSettings",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRates_DataKey",
                schema: "dbo",
                table: "ExchangeRates",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDispatches_DataKey",
                schema: "dbo",
                table: "OrderDispatches",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDispatchProducts_DataKey",
                schema: "dbo",
                table: "OrderDispatchProducts",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDispatchProducts_DispatchHeaderId",
                schema: "dbo",
                table: "OrderDispatchProducts",
                column: "DispatchHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DataKey",
                schema: "dbo",
                table: "OrderItems",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderHeaderId",
                schema: "dbo",
                table: "OrderItems",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderReturnItems_DataKey",
                schema: "dbo",
                table: "OrderReturnItems",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderReturnItems_OrderHeaderId",
                schema: "dbo",
                table: "OrderReturnItems",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ChannelCode",
                schema: "dbo",
                table: "Orders",
                column: "ChannelCode");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DataKey",
                schema: "dbo",
                table: "Orders",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_DataKey",
                schema: "dbo",
                table: "OrderStatuses",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_PackageAttachProducts_DataKey",
                schema: "dbo",
                table: "PackageAttachProducts",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_PackageAttachProducts_PackageId",
                schema: "dbo",
                table: "PackageAttachProducts",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_DataKey",
                schema: "dbo",
                table: "Packages",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBundles_DataKey",
                schema: "dbo",
                table: "ProductBundles",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_DataKey",
                schema: "dbo",
                table: "ProductCategories",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProductJanCodes_DataKey",
                schema: "dbo",
                table: "ProductJanCodes",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "dbo",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DataKey",
                schema: "dbo",
                table: "Products",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStatuses_DataKey",
                schema: "dbo",
                table: "ProductStatuses",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStocks_DataKey",
                schema: "dbo",
                table: "ProductStocks",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_SalesData_DataKey",
                schema: "dbo",
                table: "SalesData",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingCountries_DataKey",
                schema: "dbo",
                table: "ShippingCountries",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockInOutItems_DataKey",
                schema: "dbo",
                table: "StockInOutItems",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockInOuts_DataKey",
                schema: "dbo",
                table: "StockInOuts",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockLocations_DataKey",
                schema: "dbo",
                table: "StockLocations",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockTypes_DataKey",
                schema: "dbo",
                table: "StockTypes",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_DataKey",
                schema: "dbo",
                table: "Suppliers",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_SystemClassCompanies_DataKey",
                schema: "dbo",
                table: "SystemClassCompanies",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_TaskChatHistories_DataKey",
                schema: "dbo",
                table: "TaskChatHistories",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_TaskChatHistories_TaskId",
                schema: "dbo",
                table: "TaskChatHistories",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DataKey",
                schema: "dbo",
                table: "Tasks",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPLWarehouses_DataKey",
                schema: "dbo",
                table: "ThirdPLWarehouses",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_DataKey",
                schema: "dbo",
                table: "UserSettings",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_UserVendors_DataKey",
                schema: "dbo",
                table: "UserVendors",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_DataKey",
                schema: "dbo",
                table: "Vendors",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseUserSettings_DataKey",
                schema: "dbo",
                table: "WarehouseUserSettings",
                column: "DataKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiCodes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ArrivalInstructions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Batches",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Batches",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "BatchSchedules",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Bins",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CountryMasters",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CurrencyPairSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Devices",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "ExchangeRates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "LogTime",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "MstUserSettings",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "NumberSequences",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "OrderDispatchProducts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderReturnItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderStatuses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PackageAttachProducts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "PermissionsTenants",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "ProductBundles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductJanCodes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductStatuses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductStocks",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RefreshTokens",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "ReturnOrderLines",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "ReturnOrders",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "RoleToPermissions",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "RoleToPermissionTenants",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "SalesData",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ShippingBoxes",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "ShippingCarriers",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "ShippingCountries",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockInOutItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockInOuts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockLocations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockTypes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Suppliers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SystemClassCompanies",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SystemMaxPKNos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TaskChatHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TaskSchedules",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TempShopifyOrderProducts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TempShopifyOrders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ThirdPLWarehouses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Units",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "UserSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserToTenant",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "UserVendors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Vendors",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WarehousePickingLines",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehousePickingList",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehousePickingStaging",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehousePutAwayLines",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehousePutAways",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehousePutAwayStaging",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseReceiptOrder",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseReceiptOrderLine",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseReceiptStaging",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseShipmentLines",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseShipments",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseTrans",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "WarehouseUserSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderDispatches",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Packages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Tasks",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Channels",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ChannelMasters",
                schema: "dbo");
        }
    }
}
