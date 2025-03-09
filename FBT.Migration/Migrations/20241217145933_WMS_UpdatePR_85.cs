using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdatePR_85 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShippingCarrierCode",
                schema: "wms",
                table: "ShippingBoxes",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ShippingCarrierId",
                schema: "wms",
                table: "ShippingBoxes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                schema: "wms",
                table: "InventAdjustments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingCarrierCode",
                schema: "wms",
                table: "ShippingBoxes");

            migrationBuilder.DropColumn(
                name: "ShippingCarrierId",
                schema: "wms",
                table: "ShippingBoxes");

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                schema: "wms",
                table: "InventAdjustments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
