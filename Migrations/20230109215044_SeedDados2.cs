using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class SeedDados2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "CarrinhoModelId", "Nome", "Preco", "Tipo", "URLImagemItem" },
                values: new object[,]
                {
                    { 20, null, "Eco de Luden", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9a3499b1ce0e8a47/5fa1f08567a7c354926051d4/6655_Mage_T4_LudensTempest.png" },
                    { 21, null, "Mata-Cráquens", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltcb7a3c892dac6359/5fa1f08ccb9eba781f087dc8/6672_Marksman_T4_KrakenSlayer.png" },
                    { 22, null, "Crepúsculo de Draktharr", 3100m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt56608d19bafa7adf/5fa1f08c432f517518d427cc/6691_Assassin_T4_DuskbladeOfDraktharr.png" },
                    { 23, null, "Armadura de Warmog", 3000m, 3, "https://pbs.twimg.com/media/E4-p9h-WEAcvt_u.jpg" },
                    { 24, null, "Colhedor Noturno", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltaf02a9ed2a06c61d/5fa1f06f6178a9645452d2d4/4636_Mage_T4_NightHarvester.png" },
                    { 25, null, "Arco-escudo Imortal", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blteaebe960fa64ee65/5fa1f0936178a9645452d2dc/6673_Marksman_T4_ImmortalShieldbow.png" },
                    { 26, null, "Gume do infinito", 3400m, 1, "https://unbiased-gamer.com/wp-content/uploads/2021/12/Gume_do_Infinito-300x300.png" },
                    { 27, null, "Manopla dos Glacinatas", 2700m, 3, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9bfd9768726a2365/636c73198b1a6210a79a0b47/111522_Patch_12_22_Notes_Iceborn_Gauntlet.png" },
                    { 28, null, "Capuz da Morte de Rabadon", 3600m, 0, "https://pbs.twimg.com/media/E4_HJB4XIAM9XEq.jpg" },
                    { 29, null, "Dançarina Fantasma", 2600m, 2, "https://pm1.narvii.com/6601/6e79bf4d699ed9c08bbe9702a0151cebb49b7c1a_hq.jpg" },
                    { 30, null, "Colhedor de Essência", 2800m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt1c833ea361139340/5fa1f019432f517518d427b8/3508_Marksman_T3_EssenceReaver.png" },
                    { 31, null, "Quimiotanque Turbo", 2800m, 3, "https://pbs.twimg.com/media/ErLau-GXcAAmgje.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Itens",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "CarrinhoModelId", "Nome", "Preco", "Tipo", "URLImagemItem" },
                values: new object[,]
                {
                    { 1, null, "Eco de Luden", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9a3499b1ce0e8a47/5fa1f08567a7c354926051d4/6655_Mage_T4_LudensTempest.png" },
                    { 2, null, "Mata-Cráquens", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltcb7a3c892dac6359/5fa1f08ccb9eba781f087dc8/6672_Marksman_T4_KrakenSlayer.png" },
                    { 3, null, "Crepúsculo de Draktharr", 3100m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt56608d19bafa7adf/5fa1f08c432f517518d427cc/6691_Assassin_T4_DuskbladeOfDraktharr.png" },
                    { 4, null, "Armadura de Warmog", 3000m, 3, "https://pbs.twimg.com/media/E4-p9h-WEAcvt_u.jpg" },
                    { 5, null, "Colhedor Noturno", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltaf02a9ed2a06c61d/5fa1f06f6178a9645452d2d4/4636_Mage_T4_NightHarvester.png" },
                    { 6, null, "Arco-escudo Imortal", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blteaebe960fa64ee65/5fa1f0936178a9645452d2dc/6673_Marksman_T4_ImmortalShieldbow.png" },
                    { 7, null, "Gume do infinito", 3400m, 1, "https://unbiased-gamer.com/wp-content/uploads/2021/12/Gume_do_Infinito-300x300.png" },
                    { 8, null, "Manopla dos Glacinatas", 2700m, 3, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9bfd9768726a2365/636c73198b1a6210a79a0b47/111522_Patch_12_22_Notes_Iceborn_Gauntlet.png" },
                    { 9, null, "Capuz da Morte de Rabadon", 3600m, 0, "https://pbs.twimg.com/media/E4_HJB4XIAM9XEq.jpg" },
                    { 10, null, "Dançarina Fantasma", 2600m, 2, "https://pm1.narvii.com/6601/6e79bf4d699ed9c08bbe9702a0151cebb49b7c1a_hq.jpg" },
                    { 11, null, "Colhedor de Essência", 2800m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt1c833ea361139340/5fa1f019432f517518d427b8/3508_Marksman_T3_EssenceReaver.png" },
                    { 12, null, "Quimiotanque Turbo", 2800m, 3, "https://pbs.twimg.com/media/ErLau-GXcAAmgje.jpg" }
                });
        }
    }
}
