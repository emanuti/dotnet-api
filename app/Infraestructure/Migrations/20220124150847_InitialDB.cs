using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContasCorrentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pessoa_fisica_id = table.Column<int>(type: "int", nullable: false),
                    agencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contacorrente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    saldo_abertura = table.Column<float>(type: "real", nullable: false),
                    saldo = table.Column<float>(type: "real", nullable: false),
                    dt_ultima_movimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    st_ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasCorrentes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    conta_corrente_id = table.Column<int>(type: "int", nullable: false),
                    operacao_id = table.Column<int>(type: "int", nullable: false),
                    dt_movimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    st_ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Operacoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_id = table.Column<int>(type: "int", nullable: false),
                    st_ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operacoes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PessoasFisicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nu_sexo = table.Column<int>(type: "int", nullable: false),
                    st_ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoasFisicas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasCorrentes");

            migrationBuilder.DropTable(
                name: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "Operacoes");

            migrationBuilder.DropTable(
                name: "PessoasFisicas");
        }
    }
}
