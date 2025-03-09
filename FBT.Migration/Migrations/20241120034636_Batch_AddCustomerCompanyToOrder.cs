using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_AddCustomerCompanyToOrder : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isCalledApiDelivery",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "isSelectedDeliveryCompany",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "OrderedCompanyName",
                schema: "dbo",
                table: "TempShopifyOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderedCompanyName",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CallingApiDeliveryStatus",
                schema: "dbo",
                table: "OrderDispatches",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderedCompanyName",
                schema: "dbo",
                table: "TempShopifyOrders");

            migrationBuilder.DropColumn(
                name: "OrderedCompanyName",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CallingApiDeliveryStatus",
                schema: "dbo",
                table: "OrderDispatches");

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
    }
}
