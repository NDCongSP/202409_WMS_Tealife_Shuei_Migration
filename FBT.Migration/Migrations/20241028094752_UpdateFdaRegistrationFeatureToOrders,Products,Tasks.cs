using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFdaRegistrationFeatureToOrdersProductsTasks : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FDALink",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                schema: "dbo",
                table: "TempShopifyOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FdaRegistrationId",
                schema: "dbo",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFdaRegistration",
                schema: "dbo",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FdaRegistrationStatus",
                schema: "dbo",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShopifyTags",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                schema: "dbo",
                table: "TempShopifyOrders");

            migrationBuilder.DropColumn(
                name: "FdaRegistrationId",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IsFdaRegistration",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FdaRegistrationStatus",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShopifyTags",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "FDALink",
                schema: "dbo",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
