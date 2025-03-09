using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMSUpdatePR46 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ErrorImages",
                schema: "wms",
                table: "WarehouseReceiptStaging",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErrorImages",
                schema: "wms",
                table: "WarehouseReceiptOrderLine",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErrorImages",
                schema: "wms",
                table: "WarehouseReceiptStaging");

            migrationBuilder.DropColumn(
                name: "ErrorImages",
                schema: "wms",
                table: "WarehouseReceiptOrderLine");
        }
    }
}
