using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class UpDateForWMS : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleToPermissionTenants",
                schema: "wms",
                table: "RoleToPermissionTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleToPermissions",
                schema: "wms",
                table: "RoleToPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionsTenants",
                schema: "wms",
                table: "PermissionsTenants");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.DropColumn(
                name: "SalesNo",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.DropColumn(
                name: "ShipmentNo",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.DropColumn(
                name: "ShippingCarrierCode",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                schema: "dbo",
                table: "ProductJanCodes");

            migrationBuilder.RenameTable(
                name: "RoleToPermissionTenants",
                schema: "wms",
                newName: "RoleToPermissionTenant",
                newSchema: "wms");

            migrationBuilder.RenameTable(
                name: "RoleToPermissions",
                schema: "wms",
                newName: "RoleToPermission",
                newSchema: "wms");

            migrationBuilder.RenameTable(
                name: "PermissionsTenants",
                schema: "wms",
                newName: "PermissionsTenant",
                newSchema: "wms");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                schema: "wms",
                table: "WarehousePickingStaging",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "Desciption",
                schema: "wms",
                table: "PermissionsTenant",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReceiptLineId",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "PutAwayLineId",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ExpiryDate",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "date",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "dbo",
                table: "Suppliers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductStatus",
                schema: "dbo",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "dbo",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "MakerManagementCode",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductShortName",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductUrl",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopifyAdminGraphqlApiId",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopifyInventoryItemId",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopifyLocationId",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "StandardPrice",
                schema: "dbo",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorProductName",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WarehouseProcessingFlag",
                schema: "dbo",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                schema: "dbo",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                schema: "dbo",
                table: "ProductJanCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "dbo",
                table: "ProductCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "dbo",
                table: "ProductCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress1",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress2",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress3",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryName",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryPhone",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryZipcode",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockUpStatus",
                schema: "dbo",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleToPermissionTenant",
                schema: "wms",
                table: "RoleToPermissionTenant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleToPermission",
                schema: "wms",
                table: "RoleToPermission",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionsTenant",
                schema: "wms",
                table: "PermissionsTenant",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "WarehouseParameters",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseParameters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarehouseParameters",
                schema: "wms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleToPermissionTenant",
                schema: "wms",
                table: "RoleToPermissionTenant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleToPermission",
                schema: "wms",
                table: "RoleToPermission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionsTenant",
                schema: "wms",
                table: "PermissionsTenant");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "wms",
                table: "WarehousePutAwayStaging");

            migrationBuilder.DropColumn(
                name: "MakerManagementCode",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductShortName",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductUrl",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShopifyAdminGraphqlApiId",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShopifyInventoryItemId",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShopifyLocationId",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StandardPrice",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VendorProductName",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WarehouseProcessingFlag",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Width",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                schema: "dbo",
                table: "ProductJanCodes");

            migrationBuilder.DropColumn(
                name: "DeliveryAddress1",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryAddress2",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryAddress3",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryName",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryPhone",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryZipcode",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StockUpStatus",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "RoleToPermissionTenant",
                schema: "wms",
                newName: "RoleToPermissionTenants",
                newSchema: "wms");

            migrationBuilder.RenameTable(
                name: "RoleToPermission",
                schema: "wms",
                newName: "RoleToPermissions",
                newSchema: "wms");

            migrationBuilder.RenameTable(
                name: "PermissionsTenant",
                schema: "wms",
                newName: "PermissionsTenants",
                newSchema: "wms");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                schema: "wms",
                table: "WarehousePickingStaging",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "wms",
                table: "PermissionsTenants",
                newName: "Desciption");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReceiptLineId",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PutAwayLineId",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "OrderDate",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesNo",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentNo",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingCarrierCode",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "dbo",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductStatus",
                schema: "dbo",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "dbo",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                schema: "dbo",
                table: "ProductJanCodes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "dbo",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                schema: "dbo",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleToPermissionTenants",
                schema: "wms",
                table: "RoleToPermissionTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleToPermissions",
                schema: "wms",
                table: "RoleToPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionsTenants",
                schema: "wms",
                table: "PermissionsTenants",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "dbo",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                schema: "dbo",
                table: "Products",
                column: "CategoryId",
                principalSchema: "dbo",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
