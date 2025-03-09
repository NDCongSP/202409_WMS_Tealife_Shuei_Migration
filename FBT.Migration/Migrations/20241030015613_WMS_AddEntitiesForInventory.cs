using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_AddEntitiesForInventory : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArrivalNo",
                schema: "wms",
                table: "WarehouseReceiptOrderLine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InventTransfer",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PersonInCharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventTransfer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventTransferLines",
                schema: "wms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventTransferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransferNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<double>(type: "float", nullable: true),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FromBin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToBin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromLotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToLotNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventTransferLines", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventTransfer",
                schema: "wms");

            migrationBuilder.DropTable(
                name: "InventTransferLines",
                schema: "wms");

            migrationBuilder.DropColumn(
                name: "ArrivalNo",
                schema: "wms",
                table: "WarehouseReceiptOrderLine");
        }
    }
}
