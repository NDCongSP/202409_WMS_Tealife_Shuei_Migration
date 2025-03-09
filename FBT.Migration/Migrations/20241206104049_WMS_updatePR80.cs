using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_updatePR80 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDispatchId",
                schema: "wms",
                table: "WarehouseShipmentLines");

            migrationBuilder.AddColumn<int>(
                name: "OrderDispatchId",
                schema: "wms",
                table: "WarehouseShipments",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDispatchId",
                schema: "wms",
                table: "WarehouseShipments");

            migrationBuilder.AddColumn<int>(
                name: "OrderDispatchId",
                schema: "wms",
                table: "WarehouseShipmentLines",
                type: "int",
                nullable: true);
        }
    }
}
