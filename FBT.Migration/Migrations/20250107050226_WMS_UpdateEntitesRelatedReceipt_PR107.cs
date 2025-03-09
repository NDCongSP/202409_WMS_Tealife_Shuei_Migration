using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdateEntitesRelatedReceipt_PR107 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackingNo",
                schema: "wms",
                table: "WarehouseTrans");

            migrationBuilder.DropColumn(
                name: "PutAwayNo",
                schema: "wms",
                table: "WarehouseTrans");

            migrationBuilder.AddColumn<Guid>(
                name: "ReceiptLineIdParent",
                schema: "wms",
                table: "WarehouseReceiptOrderLine",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ReferenceNo",
                schema: "wms",
                table: "WarehousePutAways",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReferenceType",
                schema: "wms",
                table: "WarehousePutAways",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiptLineIdParent",
                schema: "wms",
                table: "WarehouseReceiptOrderLine");

            migrationBuilder.DropColumn(
                name: "ReferenceNo",
                schema: "wms",
                table: "WarehousePutAways");

            migrationBuilder.DropColumn(
                name: "ReferenceType",
                schema: "wms",
                table: "WarehousePutAways");

            migrationBuilder.AddColumn<string>(
                name: "PackingNo",
                schema: "wms",
                table: "WarehouseTrans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PutAwayNo",
                schema: "wms",
                table: "WarehouseTrans",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
