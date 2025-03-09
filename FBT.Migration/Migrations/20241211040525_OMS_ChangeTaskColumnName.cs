using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_ChangeTaskColumnName : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isTaskCreatedByBatch",
                schema: "dbo",
                table: "Tasks",
                newName: "IsTaskCreatedByBatch");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsTaskCreatedByBatch",
                schema: "dbo",
                table: "Tasks",
                newName: "isTaskCreatedByBatch");
        }
    }
}
