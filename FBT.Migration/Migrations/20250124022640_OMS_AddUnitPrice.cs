using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_AddUnitPrice : Microsoft.EntityFrameworkCore.Migrations.Migration
	{
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                schema: "dbo",
                table: "OrderItems",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                schema: "dbo",
                table: "OrderDispatchProducts",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPrice",
                schema: "dbo",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                schema: "dbo",
                table: "OrderDispatchProducts");
        }
    }
}
