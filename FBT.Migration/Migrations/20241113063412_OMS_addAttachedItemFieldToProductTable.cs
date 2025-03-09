using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_addAttachedItemFieldToProductTable : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachedItemId",
                schema: "dbo",
                table: "AttachedItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsAttachedItem",
                schema: "dbo",
                table: "Products",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAttachedItem",
                schema: "dbo",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "AttachedItemId",
                schema: "dbo",
                table: "AttachedItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
