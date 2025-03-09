using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_AddDeliveryStatusAndMarketUpdateStatusToOrder : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutoSplitDeliveryStatus",
                schema: "dbo",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMarketUpdated",
                schema: "dbo",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MarketUpdateAt",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isCalledApiDelivery",
                schema: "dbo",
                table: "Orders",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isSelectedDeliveryCompany",
                schema: "dbo",
                table: "Orders",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoSplitDeliveryStatus",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsMarketUpdated",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MarketUpdateAt",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "isCalledApiDelivery",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "isSelectedDeliveryCompany",
                schema: "dbo",
                table: "Orders");
        }
    }
}
