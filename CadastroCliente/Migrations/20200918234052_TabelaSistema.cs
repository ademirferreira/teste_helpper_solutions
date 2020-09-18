using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroCliente.Migrations
{
    public partial class TabelaSistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Documento = table.Column<string>(maxLength: 14, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(maxLength: 11, nullable: false),
                    TipoCliente = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(maxLength: 8, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 200, nullable: false),
                    Numero = table.Column<string>(maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(maxLength: 100, nullable: false),
                    Estado = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
