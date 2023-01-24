using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class ConsertandoModelItensVenda2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Vendas_VendaModelId",
                table: "ItensVendas");

            migrationBuilder.AlterColumn<int>(
                name: "VendaModelId",
                table: "ItensVendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVendas_Vendas_VendaModelId",
                table: "ItensVendas",
                column: "VendaModelId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Vendas_VendaModelId",
                table: "ItensVendas");

            migrationBuilder.AlterColumn<int>(
                name: "VendaModelId",
                table: "ItensVendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVendas_Vendas_VendaModelId",
                table: "ItensVendas",
                column: "VendaModelId",
                principalTable: "Vendas",
                principalColumn: "Id");
        }
    }
}
