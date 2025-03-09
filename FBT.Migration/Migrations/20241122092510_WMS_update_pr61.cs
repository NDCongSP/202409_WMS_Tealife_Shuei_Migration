using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_update_pr61 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DHLPickupDatetime",
                schema: "wms",
                table: "WarehouseShipments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "ExpirationDate",
                schema: "wms",
                table: "WarehousePickingLines",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DHLPickupDatetime",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                schema: "wms",
                table: "WarehousePickingLines");
        }
    }
}
