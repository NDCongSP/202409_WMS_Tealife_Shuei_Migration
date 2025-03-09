using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_UpdatePreSerProductSettingColumn : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseCost",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "BaseCostOther",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "Currency",
                schema: "dbo",
                table: "PreSetProductSettings");

            migrationBuilder.DropColumn(
                name: "StandardPrice",
                schema: "dbo",
                table: "PreSetProductSettings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BaseCost",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BaseCostOther",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "StandardPrice",
                schema: "dbo",
                table: "PreSetProductSettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
