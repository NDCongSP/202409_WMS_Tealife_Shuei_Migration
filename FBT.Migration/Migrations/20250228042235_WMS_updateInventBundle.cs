using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_updateInventBundle : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HHTInfo",
                schema: "wms",
                table: "InventBundles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HHTStatus",
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
                name: "HHTInfo",
                schema: "wms",
                table: "InventBundles");

            migrationBuilder.DropColumn(
                name: "HHTStatus",
                schema: "wms",
                table: "InventBundles");
        }
    }
}
