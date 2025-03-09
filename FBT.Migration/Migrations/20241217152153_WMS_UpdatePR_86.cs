using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdatePR_86 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ShippingBoxesId",
                schema: "wms",
                table: "WarehouseShipments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingBoxesName",
                schema: "wms",
                table: "WarehouseShipments",
                type: "nvarchar(100)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingBoxesId",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "ShippingBoxesName",
                schema: "wms",
                table: "WarehouseShipments");
        }
    }
}
