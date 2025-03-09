using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_UpdateArrivalInstructionColumn : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                schema: "dbo",
                table: "ArrivalInstructions");

            migrationBuilder.DropColumn(
                name: "ScheduledArrivalNumber",
                schema: "dbo",
                table: "ArrivalInstructions");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                schema: "dbo",
                table: "ArrivalInstructions");

            migrationBuilder.DropColumn(
                name: "SupplierName",
                schema: "dbo",
                table: "ArrivalInstructions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                schema: "dbo",
                table: "ArrivalInstructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScheduledArrivalNumber",
                schema: "dbo",
                table: "ArrivalInstructions",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                schema: "dbo",
                table: "ArrivalInstructions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                schema: "dbo",
                table: "ArrivalInstructions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
