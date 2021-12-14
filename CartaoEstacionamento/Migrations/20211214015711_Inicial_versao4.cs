using Microsoft.EntityFrameworkCore.Migrations;

namespace CartaoEstacionamento.Migrations
{
    public partial class Inicial_versao4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "PessoaViewModel");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "PessoaViewModel");

            migrationBuilder.DropColumn(
                name: "Habilitado",
                table: "PessoaViewModel");

            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "PessoaViewModel");

            migrationBuilder.DropColumn(
                name: "Profissao",
                table: "PessoaViewModel");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "PessoaViewModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "PessoaViewModel",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "PessoaViewModel",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Habilitado",
                table: "PessoaViewModel",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "PessoaViewModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Profissao",
                table: "PessoaViewModel",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "PessoaViewModel",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
