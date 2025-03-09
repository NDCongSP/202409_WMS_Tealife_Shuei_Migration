using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMSUpdateTasksEntity : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusError",
                schema: "wms",
                table: "WarehouseReceiptStaging",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PutawayLocation",
                schema: "wms",
                table: "WarehouseParameters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceivingLocation",
                schema: "wms",
                table: "WarehouseParameters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentLocation",
                schema: "wms",
                table: "WarehouseParameters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "dbo",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FdaRegistrationId",
                schema: "dbo",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LotNo",
                schema: "dbo",
                table: "Tasks",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                schema: "dbo",
                table: "Tasks",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                schema: "dbo",
                table: "Tasks",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptNo",
                schema: "dbo",
                table: "Tasks",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReceiptOrderLineId",
                schema: "dbo",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateOnly>(
                name: "TransactionDate",
                schema: "wms",
                table: "InventStockTakeRecording",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusError",
                schema: "wms",
                table: "WarehouseReceiptStaging");

            migrationBuilder.DropColumn(
                name: "PutawayLocation",
                schema: "wms",
                table: "WarehouseParameters");

            migrationBuilder.DropColumn(
                name: "ReceivingLocation",
                schema: "wms",
                table: "WarehouseParameters");

            migrationBuilder.DropColumn(
                name: "ShipmentLocation",
                schema: "wms",
                table: "WarehouseParameters");

            migrationBuilder.DropColumn(
                name: "LotNo",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ProductName",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ReceiptNo",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ReceiptOrderLineId",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "dbo",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FdaRegistrationId",
                schema: "dbo",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                schema: "wms",
                table: "InventStockTakeRecording",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
