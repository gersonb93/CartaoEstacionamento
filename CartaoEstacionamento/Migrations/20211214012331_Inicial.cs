using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartaoEstacionamento.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Telefone = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(maxLength: 255, nullable: false),
                    Cidade = table.Column<string>(maxLength: 255, nullable: false),
                    Estado = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    IdPfisica = table.Column<int>(nullable: true),
                    Nome = table.Column<string>(maxLength: 255, nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: true),
                    Profissao = table.Column<string>(maxLength: 255, nullable: true),
                    Rg = table.Column<string>(maxLength: 255, nullable: true),
                    PessoaId1 = table.Column<int>(nullable: true),
                    IdPjuridica = table.Column<int>(nullable: true),
                    NomeFantasia = table.Column<string>(maxLength: 255, nullable: true),
                    RazaoSocial = table.Column<string>(maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    PessoaJuridica_PessoaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoa_Pessoa_PessoaId1",
                        column: x => x.PessoaId1,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_Pessoa_PessoaJuridica_PessoaId1",
                        column: x => x.PessoaJuridica_PessoaId1,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaViewModel",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Telefone = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(maxLength: 255, nullable: false),
                    CEP = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(maxLength: 255, nullable: false),
                    Estado = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Senha = table.Column<string>(maxLength: 50, nullable: false),
                    Habilitado = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Profissao = table.Column<string>(maxLength: 255, nullable: false),
                    EstadoCivil = table.Column<string>(maxLength: 255, nullable: false),
                    Pontos = table.Column<int>(nullable: false),
                    NomeFantasia = table.Column<string>(maxLength: 255, nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 255, nullable: false),
                    CNPJ = table.Column<string>(nullable: false),
                    TelComercial = table.Column<string>(nullable: false),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    TipoPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaViewModel", x => x.PessoaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_PessoaId1",
                table: "Pessoa",
                column: "PessoaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_PessoaJuridica_PessoaId1",
                table: "Pessoa",
                column: "PessoaJuridica_PessoaId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "PessoaViewModel");
        }
    }
}
