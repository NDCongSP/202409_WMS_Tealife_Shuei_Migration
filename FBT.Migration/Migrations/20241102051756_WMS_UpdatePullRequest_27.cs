using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdatePullRequest_27 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReferenceNo",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReferenceType",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReferenceNo",
                schema: "wms",
                table: "WarehouseReceiptOrder");

            migrationBuilder.DropColumn(
                name: "ReferenceType",
                schema: "wms",
                table: "WarehouseReceiptOrder");
        }
    }
}
