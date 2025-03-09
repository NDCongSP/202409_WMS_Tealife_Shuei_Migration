using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_AddAttachItemTable : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttachedItems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedItemId = table.Column<int>(type: "int", nullable: false),
                    AttachedItemPriority = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApplyAllTime = table.Column<bool>(type: "bit", nullable: false),
                    IsApplyAllChannels = table.Column<bool>(type: "bit", nullable: false),
                    IsApplyAllProductTypes = table.Column<bool>(type: "bit", nullable: false),
                    IsApplyAllCategories = table.Column<bool>(type: "bit", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttachedItemCategories",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedItemId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedItemCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachedItemCategories_AttachedItems_AttachedItemId",
                        column: x => x.AttachedItemId,
                        principalSchema: "dbo",
                        principalTable: "AttachedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttachedItemChannels",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedItemId = table.Column<int>(type: "int", nullable: false),
                    ChannelMasterCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedItemChannels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachedItemChannels_AttachedItems_AttachedItemId",
                        column: x => x.AttachedItemId,
                        principalSchema: "dbo",
                        principalTable: "AttachedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttachedItemDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedItemId = table.Column<int>(type: "int", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedItemDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachedItemDetails_AttachedItems_AttachedItemId",
                        column: x => x.AttachedItemId,
                        principalSchema: "dbo",
                        principalTable: "AttachedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttachedItemProductTypes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachedItemId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    DataKey = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateOperatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachedItemProductTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachedItemProductTypes_AttachedItems_AttachedItemId",
                        column: x => x.AttachedItemId,
                        principalSchema: "dbo",
                        principalTable: "AttachedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemCategories_AttachedItemId",
                schema: "dbo",
                table: "AttachedItemCategories",
                column: "AttachedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemCategories_DataKey",
                schema: "dbo",
                table: "AttachedItemCategories",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemChannels_AttachedItemId",
                schema: "dbo",
                table: "AttachedItemChannels",
                column: "AttachedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemChannels_DataKey",
                schema: "dbo",
                table: "AttachedItemChannels",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemDetails_AttachedItemId",
                schema: "dbo",
                table: "AttachedItemDetails",
                column: "AttachedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemDetails_DataKey",
                schema: "dbo",
                table: "AttachedItemDetails",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemProductTypes_AttachedItemId",
                schema: "dbo",
                table: "AttachedItemProductTypes",
                column: "AttachedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItemProductTypes_DataKey",
                schema: "dbo",
                table: "AttachedItemProductTypes",
                column: "DataKey");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedItems_DataKey",
                schema: "dbo",
                table: "AttachedItems",
                column: "DataKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachedItemCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AttachedItemChannels",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AttachedItemDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AttachedItemProductTypes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AttachedItems",
                schema: "dbo");
        }
    }
}
