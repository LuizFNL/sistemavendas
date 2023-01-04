using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "Nome", "Preco", "Tipo", "URLImagemItem" },
                values: new object[,]
                {
                    { 3, "Crepúsculo de Draktharr", 3100m, 1, "https://static.wikia.nocookie.net/leagueoflegends/images/4/44/Duskblade_of_Draktharr_item_HD.png/revision/latest?cb=20201110223004" },
                    { 4, "Armadura de Warmog", 3000m, 3, "https://pbs.twimg.com/media/E4-p9h-WEAcvt_u.jpg" },
                    { 5, "Colhedor Noturno", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltaf02a9ed2a06c61d/5fa1f06f6178a9645452d2d4/4636_Mage_T4_NightHarvester.png" },
                    { 6, "Arco-escudo Imortal", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blteaebe960fa64ee65/5fa1f0936178a9645452d2dc/6673_Marksman_T4_ImmortalShieldbow.png" },
                    { 7, "Gume do infinito", 3400m, 1, "https://static.wikia.nocookie.net/leagueoflegends/images/b/bd/Gume_do_Infinito.png/revision/latest?cb=20210329171640&path-prefix=pt-br" },
                    { 8, "Manopla dos Glacinatas", 2700m, 3, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9bfd9768726a2365/636c73198b1a6210a79a0b47/111522_Patch_12_22_Notes_Iceborn_Gauntlet.png" },
                    { 9, "Capuz da Morte de Rabadon", 3600m, 0, "https://pbs.twimg.com/media/E4_HJB4XIAM9XEq.jpg" },
                    { 10, "Dançarina Fantasma", 2600m, 2, "https://static.wikia.nocookie.net/leagueoflegends/images/d/d8/Dan%C3%A7arina_Fantasma_item.png/revision/latest?cb=20210503170631&path-prefix=pt-br" },
                    { 11, "Colhedor de Essência", 2800m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt1c833ea361139340/5fa1f019432f517518d427b8/3508_Marksman_T3_EssenceReaver.png" },
                    { 12, "Quimiotanque Turbo", 2800m, 3, "https://pbs.twimg.com/media/ErLau-GXcAAmgje.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
