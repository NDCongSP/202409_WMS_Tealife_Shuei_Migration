using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_AddDeliveryStateCode : Microsoft.EntityFrameworkCore.Migrations.Migration
	{
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryStateCode",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApiLogs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    OrderIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiEndpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseTimestamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DurationMs = table.Column<int>(type: "int", nullable: true),
                    IsSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiLogs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiLogs",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "DeliveryStateCode",
                schema: "dbo",
                table: "Orders");
        }
    }
}
