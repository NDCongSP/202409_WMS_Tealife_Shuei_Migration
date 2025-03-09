using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdatePR32 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductQRCode",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SlipDeliveryPrinting",
                schema: "dbo",
                table: "ProductCategories",
                type: "nvarchar(500)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQRCode",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.DropColumn(
                name: "SlipDeliveryPrinting",
                schema: "dbo",
                table: "ProductCategories");
        }
    }
}
