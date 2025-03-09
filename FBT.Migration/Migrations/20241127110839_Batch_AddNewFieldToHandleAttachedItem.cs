using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class Batch_AddNewFieldToHandleAttachedItem : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAttachedItem",
                schema: "dbo",
                table: "OrderItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ParentItemCode",
                schema: "dbo",
                table: "OrderDispatchProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                schema: "dbo",
                table: "OrderDispatchProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                schema: "dbo",
                table: "OrderDispatchProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isAttachedItem",
                schema: "dbo",
                table: "OrderDispatchProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FdaRegistrationStatus",
                schema: "dbo",
                table: "OrderDispatches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StockUpStatus",
                schema: "dbo",
                table: "OrderDispatches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAttachedItem",
                schema: "dbo",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ParentItemCode",
                schema: "dbo",
                table: "OrderDispatchProducts");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                schema: "dbo",
                table: "OrderDispatchProducts");

            migrationBuilder.DropColumn(
                name: "ProductName",
                schema: "dbo",
                table: "OrderDispatchProducts");

            migrationBuilder.DropColumn(
                name: "isAttachedItem",
                schema: "dbo",
                table: "OrderDispatchProducts");

            migrationBuilder.DropColumn(
                name: "FdaRegistrationStatus",
                schema: "dbo",
                table: "OrderDispatches");

            migrationBuilder.DropColumn(
                name: "StockUpStatus",
                schema: "dbo",
                table: "OrderDispatches");
        }
    }
}
