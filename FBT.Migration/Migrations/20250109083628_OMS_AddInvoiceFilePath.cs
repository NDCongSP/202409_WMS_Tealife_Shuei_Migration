using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_AddInvoiceFilePath : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceFileExtension",
                schema: "dbo",
                table: "OrderDispatches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceFilePath",
                schema: "dbo",
                table: "OrderDispatches",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceFileExtension",
                schema: "dbo",
                table: "OrderDispatches");

            migrationBuilder.DropColumn(
                name: "InvoiceFilePath",
                schema: "dbo",
                table: "OrderDispatches");
        }
    }
}
