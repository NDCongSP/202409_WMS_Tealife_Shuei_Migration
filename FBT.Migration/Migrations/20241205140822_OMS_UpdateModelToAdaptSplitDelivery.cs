using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_UpdateModelToAdaptSplitDelivery : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationStatus",
                schema: "dbo",
                table: "FdaRegistrations");

            migrationBuilder.AddColumn<string>(
                name: "DeliveryId",
                schema: "dbo",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderDispatchStatus",
                schema: "dbo",
                table: "OrderDispatches",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryId",
                schema: "dbo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OrderDispatchStatus",
                schema: "dbo",
                table: "OrderDispatches");

            migrationBuilder.AddColumn<int>(
                name: "RegistrationStatus",
                schema: "dbo",
                table: "FdaRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
