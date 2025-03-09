using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMSUpdatePR44 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipmentId",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.AddColumn<string>(
                name: "ShipmentNo",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentNo",
                schema: "wms",
                table: "WarehousePickingLines",
                type: "nvarchar(100)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipmentNo",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.DropColumn(
                name: "ShipmentNo",
                schema: "wms",
                table: "WarehousePickingLines");

            migrationBuilder.AddColumn<Guid>(
                name: "ShipmentId",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
