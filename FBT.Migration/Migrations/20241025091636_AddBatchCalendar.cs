using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class AddBatchCalendar : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBatchInRequest",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "IsFailed",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "IsStopped",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "Priority",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                schema: "dbo",
                table: "BatchSchedules",
                newName: "ScheduleDivision");

            migrationBuilder.AddColumn<string>(
                name: "DayOfWeek",
                schema: "dbo",
                table: "BatchSchedules",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                schema: "dbo",
                table: "BatchSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ScheduleTime",
                schema: "dbo",
                table: "BatchSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ScheduleType",
                schema: "dbo",
                table: "BatchSchedules",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                schema: "dbo",
                table: "BatchSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "BatchCalendars",
                schema: "dbo",
                columns: table => new
                {
                    Date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScheduleType = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchCalendars", x => x.Date);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchCalendars",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "EndTime",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "ScheduleTime",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "ScheduleType",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.DropColumn(
                name: "StartTime",
                schema: "dbo",
                table: "BatchSchedules");

            migrationBuilder.RenameColumn(
                name: "ScheduleDivision",
                schema: "dbo",
                table: "BatchSchedules",
                newName: "RequestId");

            migrationBuilder.AddColumn<bool>(
                name: "IsBatchInRequest",
                schema: "dbo",
                table: "BatchSchedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFailed",
                schema: "dbo",
                table: "BatchSchedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStopped",
                schema: "dbo",
                table: "BatchSchedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Priority",
                schema: "dbo",
                table: "BatchSchedules",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
