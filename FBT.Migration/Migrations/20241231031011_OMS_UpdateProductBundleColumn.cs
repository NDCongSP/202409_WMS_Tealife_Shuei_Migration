using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_UpdateProductBundleColumn : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildProductStatus",
                schema: "dbo",
                table: "ProductBundles");

            migrationBuilder.DropColumn(
                name: "EndTime",
                schema: "dbo",
                table: "ProductBundles");

            migrationBuilder.DropColumn(
                name: "SaleProductBundleCode",
                schema: "dbo",
                table: "ProductBundles");

            migrationBuilder.DropColumn(
                name: "StartTime",
                schema: "dbo",
                table: "ProductBundles");

            migrationBuilder.AddColumn<double>(
                name: "BaseCost",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BaseCostOther",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "StandardPrice",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseCost",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "BaseCostOther",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "Currency",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "StandardPrice",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.AddColumn<int>(
                name: "ChildProductStatus",
                schema: "dbo",
                table: "ProductBundles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "ProductBundles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleProductBundleCode",
                schema: "dbo",
                table: "ProductBundles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "ProductBundles",
                type: "datetime2",
                nullable: true);
        }
    }
}
