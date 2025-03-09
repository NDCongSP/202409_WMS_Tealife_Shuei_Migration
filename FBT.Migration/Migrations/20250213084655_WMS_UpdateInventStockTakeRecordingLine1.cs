using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdateInventStockTakeRecordingLine1 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockTakeRecoringId",
                schema: "wms",
                table: "InventStockTakeRecordingLines",
                newName: "StockTakeRecordingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockTakeRecordingId",
                schema: "wms",
                table: "InventStockTakeRecordingLines",
                newName: "StockTakeRecoringId");
        }
    }
}
