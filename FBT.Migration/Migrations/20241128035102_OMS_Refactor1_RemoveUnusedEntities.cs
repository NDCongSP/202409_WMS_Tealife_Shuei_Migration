using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_Refactor1_RemoveUnusedEntities : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderReturnItems",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PackageAttachProducts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WarehouseUserSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Packages",
                schema: "dbo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderReturnItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnQuantity = table.Column<int>(type: "int", nullable: true),
                    SalesProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderReturnItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderReturnItems_Orders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    OrderChannel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseUserSettings",
                schema: "dbo",
                columns: table => new
                {
                    WarehouseUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarehouseCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseUserSettings", x => x.WarehouseUserId);
                });

            migrationBuilder.CreateTable(
                name: "PackageAttachProducts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    AttachProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageAttachProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageAttachProducts_Packages_PackageId",
                        column: x => x.PackageId,
                        principalSchema: "dbo",
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DataKey",
                schema: "dbo",
                table: "Categories",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderReturnItems_DataKey",
                schema: "dbo",
                table: "OrderReturnItems",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_OrderReturnItems_OrderHeaderId",
                schema: "dbo",
                table: "OrderReturnItems",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageAttachProducts_DataKey",
                schema: "dbo",
                table: "PackageAttachProducts",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_PackageAttachProducts_PackageId",
                schema: "dbo",
                table: "PackageAttachProducts",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_DataKey",
                schema: "dbo",
                table: "Packages",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseUserSettings_DataKey",
                schema: "dbo",
                table: "WarehouseUserSettings",
                column: "DataKey");
        }
    }
}
