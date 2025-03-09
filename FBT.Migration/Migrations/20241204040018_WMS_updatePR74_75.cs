using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_updatePR74_75 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArrivalNo",
                schema: "wms",
                table: "WarehouseReceiptOrderLine",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ScheduledArrivalNumber",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickingBoxCode",
                schema: "wms",
                table: "WarehousePickingStaging",
                type: "nvarchar(100)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickingBoxCode",
                schema: "wms",
                table: "WarehousePickingStaging");

            migrationBuilder.AlterColumn<int>(
                name: "ArrivalNo",
                schema: "wms",
                table: "WarehouseReceiptOrderLine",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScheduledArrivalNumber",
                schema: "wms",
                table: "WarehouseReceiptOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
