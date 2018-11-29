using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleVinivius.Migrations
{
    public partial class dbTablog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tablog",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablog", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tablog");
        }
    }
}
