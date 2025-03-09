using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class AddForecastedSalesDataTable : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForecastedSalesDatas",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ForecastedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForecastedChannel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForecastedSalesAmount = table.Column<float>(type: "real", nullable: false),
                    ForecastedProfitAmount = table.Column<float>(type: "real", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForecastedSalesDatas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForecastedSalesDatas_DataKey",
                schema: "dbo",
                table: "ForecastedSalesDatas",
                column: "DataKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForecastedSalesDatas",
                schema: "dbo");
        }
    }
}
