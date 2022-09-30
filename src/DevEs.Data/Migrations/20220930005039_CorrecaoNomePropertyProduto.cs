using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevEs.Data.Migrations
{
    public partial class CorrecaoNomePropertyProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Produtos",
                newName: "DataCadastro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Produtos",
                newName: "MyProperty");
        }
    }
}
