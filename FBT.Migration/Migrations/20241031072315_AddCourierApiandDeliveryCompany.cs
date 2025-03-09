using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class AddCourierApiandDeliveryCompany : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourierApis",
                schema: "dbo",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CourierCd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApiParam = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApiValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourierApis", x => new { x.CompanyId, x.CourierCd, x.ApiParam });
                });

            migrationBuilder.CreateTable(
                name: "DeliveryCompanies",
                schema: "dbo",
                columns: table => new
                {
                    DeliveryCompanyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeliveryCompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentDeliveryCompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentDeliveryCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsingApi = table.Column<bool>(type: "bit", nullable: false),
                    WeightMin = table.Column<int>(type: "int", nullable: true),
                    WeightMax = table.Column<int>(type: "int", nullable: true),
                    ServiceLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChCustomerRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChAddressRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavDeliveryCompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgtCarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgtTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelExportModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultPriceRestriction = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DefaultWeightRestriction = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DefaultQtyRestriction = table.Column<long>(type: "bigint", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCompanies", x => x.DeliveryCompanyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourierApis",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DeliveryCompanies",
                schema: "dbo");
        }
    }
}
