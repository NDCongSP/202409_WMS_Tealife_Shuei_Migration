using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWarehouseShipping : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bin",
                schema: "wms",
                table: "WarehouseShipmentLines");

            migrationBuilder.DropColumn(
                name: "Location",
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

            migrationBuilder.RenameColumn(
                name: "Location",
                schema: "wms",
                table: "WarehouseShipments",
                newName: "TenantName");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "wms",
                table: "WarehouseShipments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                schema: "wms",
                table: "WarehouseShipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonInChargeName",
                schema: "wms",
                table: "WarehouseShipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BinId",
                schema: "wms",
                table: "WarehouseShipmentLines",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "LocationName",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.DropColumn(
                name: "PersonInChargeName",
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

            migrationBuilder.RenameColumn(
                name: "TenantName",
                schema: "wms",
                table: "WarehouseShipments",
                newName: "Location");

            migrationBuilder.AddColumn<string>(
                name: "Bin",
                schema: "wms",
                table: "WarehouseShipmentLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
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
        }
    }
}
