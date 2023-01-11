using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class ConsertandoBugCarrinho2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 5,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 6,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 7,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 8,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 9,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 10,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 11,
                column: "CarrinhoModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 12,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
