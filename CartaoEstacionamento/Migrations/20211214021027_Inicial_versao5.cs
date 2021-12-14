using Microsoft.EntityFrameworkCore.Migrations;

namespace CartaoEstacionamento.Migrations
{
    public partial class Inicial_versao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaId1",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaJuridica_PessoaId1",
                table: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "PessoaViewModel",
                newName: "PessoaViewId");

            migrationBuilder.RenameColumn(
                name: "PessoaJuridica_PessoaId1",
                table: "Pessoa",
                newName: "PessoaJuridica_PessoaIdPessoa");

            migrationBuilder.RenameColumn(
                name: "PessoaId1",
                table: "Pessoa",
                newName: "PessoaIdPessoa");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Pessoa",
                newName: "IdPessoa");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_PessoaJuridica_PessoaId1",
                table: "Pessoa",
                newName: "IX_Pessoa_PessoaJuridica_PessoaIdPessoa");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_PessoaId1",
                table: "Pessoa",
                newName: "IX_Pessoa_PessoaIdPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaIdPessoa",
                table: "Pessoa",
                column: "PessoaIdPessoa",
                principalTable: "Pessoa",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaJuridica_PessoaIdPessoa",
                table: "Pessoa",
                column: "PessoaJuridica_PessoaIdPessoa",
                principalTable: "Pessoa",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaIdPessoa",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaJuridica_PessoaIdPessoa",
                table: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "PessoaViewId",
                table: "PessoaViewModel",
                newName: "PessoaId");

            migrationBuilder.RenameColumn(
                name: "PessoaJuridica_PessoaIdPessoa",
                table: "Pessoa",
                newName: "PessoaJuridica_PessoaId1");

            migrationBuilder.RenameColumn(
                name: "PessoaIdPessoa",
                table: "Pessoa",
                newName: "PessoaId1");

            migrationBuilder.RenameColumn(
                name: "IdPessoa",
                table: "Pessoa",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_PessoaJuridica_PessoaIdPessoa",
                table: "Pessoa",
                newName: "IX_Pessoa_PessoaJuridica_PessoaId1");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoa_PessoaIdPessoa",
                table: "Pessoa",
                newName: "IX_Pessoa_PessoaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaId1",
                table: "Pessoa",
                column: "PessoaId1",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Pessoa_PessoaJuridica_PessoaId1",
                table: "Pessoa",
                column: "PessoaJuridica_PessoaId1",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
