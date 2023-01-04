using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "Nome", "Preco", "Tipo", "URLImagemItem" },
                values: new object[] { 1, "Eco de Luden", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9a3499b1ce0e8a47/5fa1f08567a7c354926051d4/6655_Mage_T4_LudensTempest.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
