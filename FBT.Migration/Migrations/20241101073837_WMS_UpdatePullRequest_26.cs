using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdatePullRequest_26 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipTo",
                schema: "wms",
                table: "ReturnOrders");

            migrationBuilder.AddColumn<int>(
                name: "ShipmentType",
                schema: "wms",
                table: "WarehouseShipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReceiptLineId",
                schema: "wms",
                table: "WarehousePutAwayLines",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipmentType",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReceiptLineId",
                schema: "wms",
                table: "WarehousePutAwayLines",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipTo",
                schema: "wms",
                table: "ReturnOrders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
