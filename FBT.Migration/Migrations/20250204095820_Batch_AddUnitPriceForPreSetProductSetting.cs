using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_AddUnitPriceForPreSetProductSetting : Microsoft.EntityFrameworkCore.Migrations.Migration
	{
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConvertPrice",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfTimes",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConvertPrice",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "NumberOfTimes",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                schema: "dbo",
                table: "PreSetProductSettings");
        }
    }
}
