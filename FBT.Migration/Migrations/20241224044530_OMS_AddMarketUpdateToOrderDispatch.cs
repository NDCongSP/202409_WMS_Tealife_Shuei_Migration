using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_AddMarketUpdateToOrderDispatch : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockInOutItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockInOuts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockLocations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StockTypes",
                schema: "dbo");

            migrationBuilder.AddColumn<bool>(
                name: "IsMarketUpdated",
                schema: "dbo",
                table: "OrderDispatches",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMarketUpdated",
                schema: "dbo",
                table: "OrderDispatches");

            migrationBuilder.CreateTable(
                name: "StockInOutItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ItemCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInOutItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockInOuts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InOutCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LocationCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    StockCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInOuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockLocations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    LocationCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockTypes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    StockCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockInOutItems_DataKey",
                schema: "dbo",
                table: "StockInOutItems",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockInOuts_DataKey",
                schema: "dbo",
                table: "StockInOuts",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockLocations_DataKey",
                schema: "dbo",
                table: "StockLocations",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_StockTypes_DataKey",
                schema: "dbo",
                table: "StockTypes",
                column: "DataKey");
        }
    }
}
