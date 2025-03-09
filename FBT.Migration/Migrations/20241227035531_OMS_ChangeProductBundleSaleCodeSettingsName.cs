using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_ChangeProductBundleSaleCodeSettingsName : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBundleSaleCodeSettings",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "PreSetProductSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SaleProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductBundleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularPrice = table.Column<double>(type: "float", nullable: false),
                    FromApplyPreBundles = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToApplyPreBundles = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreSetProductSettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreSetProductSettings_DataKey",
                schema: "dbo",
                table: "PreSetProductSettings",
                column: "DataKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreSetProductSettings",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "ProductBundleSaleCodeSettings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FromApplyPreBundles = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ProductBundleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularPrice = table.Column<double>(type: "float", nullable: false),
                    SaleProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToApplyPreBundles = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBundleSaleCodeSettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBundleSaleCodeSettings_DataKey",
                schema: "dbo",
                table: "ProductBundleSaleCodeSettings",
                column: "DataKey");
        }
    }
}
