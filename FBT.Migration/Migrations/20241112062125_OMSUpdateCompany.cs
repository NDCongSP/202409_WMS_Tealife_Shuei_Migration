using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMSUpdateCompany : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                schema: "dbo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactEmailAddress",
                schema: "dbo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryNoteMessage",
                schema: "dbo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoImage",
                schema: "dbo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                schema: "dbo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteAddress",
                schema: "dbo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                schema: "dbo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContactEmailAddress",
                schema: "dbo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DeliveryNoteMessage",
                schema: "dbo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LogoImage",
                schema: "dbo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ShopName",
                schema: "dbo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "SiteAddress",
                schema: "dbo",
                table: "Companies");
        }
    }
}
