using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_UpdateShippingRuleColumnName : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                schema: "dbo",
                table: "ShippingRules",
                newName: "StateCode");

            migrationBuilder.RenameColumn(
                name: "Country",
                schema: "dbo",
                table: "ShippingRules",
                newName: "CountryCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateCode",
                schema: "dbo",
                table: "ShippingRules",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "CountryCode",
                schema: "dbo",
                table: "ShippingRules",
                newName: "Country");
        }
    }
}
