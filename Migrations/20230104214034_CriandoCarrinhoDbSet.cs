using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sistemavendas.Migrations
{
    /// <inheritdoc />
    public partial class CriandoCarrinhoDbSet : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Itens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NomeId",
                table: "Itens",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "Discriminator", "Nome", "Preco", "Tipo", "URLImagemItem" },
                values: new object[,]
                {
                    { 1, "ItensModel", "Eco de Luden", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9a3499b1ce0e8a47/5fa1f08567a7c354926051d4/6655_Mage_T4_LudensTempest.png" },
                    { 2, "ItensModel", "Mata-Cráquens", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltcb7a3c892dac6359/5fa1f08ccb9eba781f087dc8/6672_Marksman_T4_KrakenSlayer.png" },
                    { 3, "ItensModel", "Crepúsculo de Draktharr", 3100m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt56608d19bafa7adf/5fa1f08c432f517518d427cc/6691_Assassin_T4_DuskbladeOfDraktharr.png" },
                    { 4, "ItensModel", "Armadura de Warmog", 3000m, 3, "https://pbs.twimg.com/media/E4-p9h-WEAcvt_u.jpg" },
                    { 5, "ItensModel", "Colhedor Noturno", 3200m, 0, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltaf02a9ed2a06c61d/5fa1f06f6178a9645452d2d4/4636_Mage_T4_NightHarvester.png" },
                    { 6, "ItensModel", "Arco-escudo Imortal", 3400m, 2, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blteaebe960fa64ee65/5fa1f0936178a9645452d2dc/6673_Marksman_T4_ImmortalShieldbow.png" },
                    { 7, "ItensModel", "Gume do infinito", 3400m, 1, "https://unbiased-gamer.com/wp-content/uploads/2021/12/Gume_do_Infinito-300x300.png" },
                    { 8, "ItensModel", "Manopla dos Glacinatas", 2700m, 3, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9bfd9768726a2365/636c73198b1a6210a79a0b47/111522_Patch_12_22_Notes_Iceborn_Gauntlet.png" },
                    { 9, "ItensModel", "Capuz da Morte de Rabadon", 3600m, 0, "https://pbs.twimg.com/media/E4_HJB4XIAM9XEq.jpg" },
                    { 10, "ItensModel", "Dançarina Fantasma", 2600m, 2, "https://pm1.narvii.com/6601/6e79bf4d699ed9c08bbe9702a0151cebb49b7c1a_hq.jpg" },
                    { 11, "ItensModel", "Colhedor de Essência", 2800m, 1, "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt1c833ea361139340/5fa1f019432f517518d427b8/3508_Marksman_T3_EssenceReaver.png" },
                    { 12, "ItensModel", "Quimiotanque Turbo", 2800m, 3, "https://pbs.twimg.com/media/ErLau-GXcAAmgje.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "NomeId",
                table: "Itens");
        }
    }
}
