using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 2,
                column: "URLImagemItem",
                value: "https://static.wikia.nocookie.net/leagueoflegends/images/f/fd/Mata-Cr%C3%A1quens_item.png/revision/latest?cb=20210301010130&path-prefix=pt-br");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 2,
                column: "URLImagemItem",
                value: "https://static.wikia.nocookie.net/leagueoflegends/images/f/fd/Mata-Cr%C3%A1quens_item.png/revision/latest/scale-to-width-down/512?cb=20210301010130&path-prefix=pt-br");
        }
    }
}
