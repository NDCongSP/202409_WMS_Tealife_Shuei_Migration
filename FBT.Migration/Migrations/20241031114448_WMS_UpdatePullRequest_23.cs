using System;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class WMS_UpdatePullRequest_23 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "wms",
                table: "InventTransfer");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "wms",
                table: "InventTransfer",
                type: "nvarchar(100)",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                schema: "wms",
                table: "InventTransfer");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "wms",
                table: "InventTransfer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
