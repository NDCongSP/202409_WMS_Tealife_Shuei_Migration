using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_AddLabelFilePathAndLabelFileExtensionToOrderDispatches : Microsoft.EntityFrameworkCore.Migrations.Migration
	{
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LabelFileExtension",
                schema: "dbo",
                table: "OrderDispatches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabelFilePath",
                schema: "dbo",
                table: "OrderDispatches",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LabelFileExtension",
                schema: "dbo",
                table: "OrderDispatches");

            migrationBuilder.DropColumn(
                name: "LabelFilePath",
                schema: "dbo",
                table: "OrderDispatches");
        }
    }
}
