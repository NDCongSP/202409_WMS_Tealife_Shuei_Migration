using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_AddDeliveryIdToFdaRegistration : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isTaskCreatedByBatch",
                schema: "dbo",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryId",
                schema: "dbo",
                table: "FdaRegistrations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isTaskCreatedByBatch",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                schema: "dbo",
                table: "FdaRegistrations");
        }
    }
}
