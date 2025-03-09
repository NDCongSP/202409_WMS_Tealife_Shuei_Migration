using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_updatePR92fromsharemodel : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "WarehousePutAways",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
                schema: "wms",
                table: "WarehousePutAways",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "WarehousePickingList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
                schema: "wms",
                table: "WarehousePickingList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "InventTransfer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
                schema: "wms",
                table: "InventTransfer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "InventStockTakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
                schema: "wms",
                table: "InventStockTakes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "InventStockTakeRecording",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
                schema: "wms",
                table: "InventStockTakeRecording",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HHTInfo",
                schema: "wms",
                table: "WarehouseReceiptOrder");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "WarehouseReceiptOrder");

            migrationBuilder.DropColumn(
                name: "HHTInfo",
                schema: "wms",
                table: "WarehousePutAways");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "WarehousePutAways");

            migrationBuilder.DropColumn(
                name: "HHTInfo",
                schema: "wms",
                table: "WarehousePickingList");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "WarehousePickingList");

            migrationBuilder.DropColumn(
                name: "HHTInfo",
                schema: "wms",
                table: "InventTransfer");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "InventTransfer");

            migrationBuilder.DropColumn(
                name: "HHTInfo",
                schema: "wms",
                table: "InventStockTakes");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "InventStockTakes");

            migrationBuilder.DropColumn(
                name: "HHTInfo",
                schema: "wms",
                table: "InventStockTakeRecording");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "InventStockTakeRecording");
        }
    }
}
