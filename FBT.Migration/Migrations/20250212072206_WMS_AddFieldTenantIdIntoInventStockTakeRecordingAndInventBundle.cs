using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_AddFieldTenantIdIntoInventStockTakeRecordingAndInventBundle : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                schema: "wms",
                table: "InventStockTakeRecording",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                schema: "wms",
                table: "InventBundles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                schema: "wms",
                table: "InventStockTakeRecording");

            migrationBuilder.DropColumn(
                name: "TenantId",
                schema: "wms",
                table: "InventBundles");
        }
    }
}
