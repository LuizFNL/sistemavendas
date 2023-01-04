using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class ConsertandoImagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 2,
                column: "URLImagemItem",
                value: "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltcb7a3c892dac6359/5fa1f08ccb9eba781f087dc8/6672_Marksman_T4_KrakenSlayer.png");

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 3,
                column: "URLImagemItem",
                value: "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt56608d19bafa7adf/5fa1f08c432f517518d427cc/6691_Assassin_T4_DuskbladeOfDraktharr.png");

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 7,
                column: "URLImagemItem",
                value: "https://unbiased-gamer.com/wp-content/uploads/2021/12/Gume_do_Infinito-300x300.png");

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 10,
                column: "URLImagemItem",
                value: "https://pm1.narvii.com/6601/6e79bf4d699ed9c08bbe9702a0151cebb49b7c1a_hq.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 2,
                column: "URLImagemItem",
                value: "https://static.wikia.nocookie.net/leagueoflegends/images/f/fd/Mata-Cr%C3%A1quens_item.png/revision/latest?cb=20210301010130&path-prefix=pt-br");

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 3,
                column: "URLImagemItem",
                value: "https://static.wikia.nocookie.net/leagueoflegends/images/4/44/Duskblade_of_Draktharr_item_HD.png/revision/latest?cb=20201110223004");

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 7,
                column: "URLImagemItem",
                value: "https://static.wikia.nocookie.net/leagueoflegends/images/b/bd/Gume_do_Infinito.png/revision/latest?cb=20210329171640&path-prefix=pt-br");

            migrationBuilder.UpdateData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 10,
                column: "URLImagemItem",
                value: "https://static.wikia.nocookie.net/leagueoflegends/images/d/d8/Dan%C3%A7arina_Fantasma_item.png/revision/latest?cb=20210503170631&path-prefix=pt-br");
        }
    }
}
