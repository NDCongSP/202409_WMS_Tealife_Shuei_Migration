using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations.IdentityForWMS
{
    /// <inheritdoc />
    public partial class UpdateIdentityUser : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "wms",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localtion",
                schema: "wms",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                schema: "wms",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "wms",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Localtion",
                schema: "wms",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "wms",
                table: "AspNetUsers");
        }
    }
}
