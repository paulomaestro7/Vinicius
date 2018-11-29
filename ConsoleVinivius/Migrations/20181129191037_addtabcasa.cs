using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleVinivius.Migrations
{
    public partial class addtabcasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabCasa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabCasa", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabCasa");
        }
    }
}
