using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableInWMS : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "BinId",
                schema: "wms",
                table: "WarehouseShipmentLines");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "wms",
                table: "WarehousePickingList");

            migrationBuilder.DropColumn(
                name: "BinId",
                schema: "wms",
                table: "WarehousePickingLines");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "wms",
                table: "WarehousePickingLines");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "wms",
                table: "WarehouseShipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BinId",
                schema: "wms",
                table: "WarehouseShipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "wms",
                table: "WarehouseShipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bin",
                schema: "wms",
                table: "WarehouseShipmentLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostedBy",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "PostedDate",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierCode",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                schema: "wms",
                table: "WarehousePutAwayLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ExpirationDate",
                schema: "wms",
                table: "WarehousePutAwayLines",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EstimatedShipDate",
                schema: "wms",
                table: "WarehousePickingList",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "wms",
                table: "WarehousePickingList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                schema: "wms",
                table: "WarehousePickingList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bin",
                schema: "wms",
                table: "WarehousePickingLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "wms",
                table: "WarehousePickingLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                schema: "dbo",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "BinId",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "Location",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "Bin",
                schema: "wms",
                table: "WarehouseShipmentLines");

            migrationBuilder.DropColumn(
                name: "PostedBy",
                schema: "wms",
                table: "WarehouseReceiptOrder");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                schema: "wms",
                table: "WarehouseReceiptOrder");

            migrationBuilder.DropColumn(
                name: "SupplierCode",
                schema: "wms",
                table: "WarehouseReceiptOrder");

            migrationBuilder.DropColumn(
                name: "Location",
                schema: "wms",
                table: "WarehousePickingList");

            migrationBuilder.DropColumn(
                name: "Remarks",
                schema: "wms",
                table: "WarehousePickingList");

            migrationBuilder.DropColumn(
                name: "Bin",
                schema: "wms",
                table: "WarehousePickingLines");

            migrationBuilder.DropColumn(
                name: "Location",
                schema: "wms",
                table: "WarehousePickingLines");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "dbo",
                table: "Suppliers");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "wms",
                table: "WarehouseShipments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BinId",
                schema: "wms",
                table: "WarehouseShipmentLines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PutAwayLineId",
                schema: "wms",
                table: "WarehousePutAwayStaging",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                schema: "wms",
                table: "WarehousePutAwayLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                schema: "wms",
                table: "WarehousePutAwayLines",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedShipDate",
                schema: "wms",
                table: "WarehousePickingList",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "wms",
                table: "WarehousePickingList",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BinId",
                schema: "wms",
                table: "WarehousePickingLines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "wms",
                table: "WarehousePickingLines",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
