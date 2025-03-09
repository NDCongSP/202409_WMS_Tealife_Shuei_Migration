using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBT.Migration.Migrations
{
    /// <inheritdoc />
    public partial class OMS_ChangeNameTableCommonStatus : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommonStatusInSystems",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "MstSystemClasses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusTittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusValue = table.Column<int>(type: "int", nullable: false),
                    JWording = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EWording = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstSystemClasses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MstSystemClasses",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "CommonStatusInSystems",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EWording = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JWording = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusTittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonStatusInSystems", x => x.Id);
                });
        }
    }
}
