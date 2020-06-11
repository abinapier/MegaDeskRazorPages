using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DeskWidth = table.Column<int>(nullable: false),
                    DeskDepth = table.Column<int>(nullable: false),
                    DrawerCount = table.Column<int>(nullable: false),
                    DeskSurfaceMaterial = table.Column<int>(nullable: false),
                    OrderTime = table.Column<int>(nullable: false),
                    DeskQuote = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
