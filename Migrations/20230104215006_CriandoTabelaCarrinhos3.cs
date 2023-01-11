using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaCarrinhos3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_Itens_NomeId",
                table: "Carrinhos");

            migrationBuilder.RenameColumn(
                name: "NomeId",
                table: "Carrinhos",
                newName: "ItensModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Carrinhos_NomeId",
                table: "Carrinhos",
                newName: "IX_Carrinhos_ItensModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhos_Itens_ItensModelId",
                table: "Carrinhos",
                column: "ItensModelId",
                principalTable: "Itens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_Itens_ItensModelId",
                table: "Carrinhos");

            migrationBuilder.RenameColumn(
                name: "ItensModelId",
                table: "Carrinhos",
                newName: "NomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Carrinhos_ItensModelId",
                table: "Carrinhos",
                newName: "IX_Carrinhos_NomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhos_Itens_NomeId",
                table: "Carrinhos",
                column: "NomeId",
                principalTable: "Itens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
