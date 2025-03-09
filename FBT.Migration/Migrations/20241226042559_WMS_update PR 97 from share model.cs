using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_updatePR97fromsharemodel : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                schema: "wms",
                table: "InventBundleLines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateOperatorId",
                schema: "wms",
                table: "InventBundleLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "wms",
                table: "InventBundleLines",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                schema: "wms",
                table: "InventBundleLines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateOperatorId",
                schema: "wms",
                table: "InventBundleLines",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                schema: "wms",
                table: "InventBundleLines");

            migrationBuilder.DropColumn(
                name: "CreateOperatorId",
                schema: "wms",
                table: "InventBundleLines");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "wms",
                table: "InventBundleLines");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                schema: "wms",
                table: "InventBundleLines");

            migrationBuilder.DropColumn(
                name: "UpdateOperatorId",
                schema: "wms",
                table: "InventBundleLines");
        }
    }
}
