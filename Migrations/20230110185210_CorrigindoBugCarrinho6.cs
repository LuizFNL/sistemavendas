using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class CorrigindoBugCarrinho6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Carrinhos_CarrinhoModelId",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_CarrinhoModelId",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "CarrinhoModelId",
                table: "Itens");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_ItensModelId",
                table: "Carrinhos",
                column: "ItensModelId");

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

            migrationBuilder.DropIndex(
                name: "IX_Carrinhos_ItensModelId",
                table: "Carrinhos");

            migrationBuilder.AddColumn<int>(
                name: "CarrinhoModelId",
                table: "Itens",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 20,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 21,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 22,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 23,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 24,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 25,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 26,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 27,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 28,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 29,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 30,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 31,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_CarrinhoModelId",
                table: "Itens",
                column: "CarrinhoModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Carrinhos_CarrinhoModelId",
                table: "Itens",
                column: "CarrinhoModelId",
                principalTable: "Carrinhos",
                principalColumn: "Id");
        }
    }
}
