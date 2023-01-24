using Microsoft.EntityFrameworkCore;
using sistemavendas.Models;
using sistemavendas.Enums;

namespace sistemavendas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<ItensModel> Itens { get; set; }
        public DbSet<VendaModel> Vendas { get; set; }
        public DbSet<ItensVenda> ItensVendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ItensModel>().HasData(
            new ItensModel
            {
                Id = 1,
                Nome = "Eco de Luden",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9a3499b1ce0e8a47/5fa1f08567a7c354926051d4/6655_Mage_T4_LudensTempest.png",
                Tipo = TipoItemEnum.Mágico,
                Preco = 3200
            },
            new ItensModel
            {
                Id = 2,
                Nome = "Mata-Cráquens",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltcb7a3c892dac6359/5fa1f08ccb9eba781f087dc8/6672_Marksman_T4_KrakenSlayer.png",
                Tipo = TipoItemEnum.Velocidade_De_Ataque,
                Preco = 3400
            },
            new ItensModel
            {
                Id = 3,
                Nome = "Crepúsculo de Draktharr",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt56608d19bafa7adf/5fa1f08c432f517518d427cc/6691_Assassin_T4_DuskbladeOfDraktharr.png",
                Tipo = TipoItemEnum.Físico,
                Preco = 3100
            },
            new ItensModel
            {
                Id = 4,
                Nome = "Armadura de Warmog",
                URLImagemItem = "https://pbs.twimg.com/media/E4-p9h-WEAcvt_u.jpg",
                Tipo = TipoItemEnum.Tanque,
                Preco = 3000
            },
            new ItensModel
            {
                Id = 5,
                Nome = "Colhedor Noturno",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltaf02a9ed2a06c61d/5fa1f06f6178a9645452d2d4/4636_Mage_T4_NightHarvester.png",
                Tipo = TipoItemEnum.Mágico,
                Preco = 3200
            },
            new ItensModel
            {
                Id = 6,
                Nome = "Arco-escudo Imortal",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blteaebe960fa64ee65/5fa1f0936178a9645452d2dc/6673_Marksman_T4_ImmortalShieldbow.png",
                Tipo = TipoItemEnum.Velocidade_De_Ataque,
                Preco = 3400
            },
            new ItensModel
            {
                Id = 7,
                Nome = "Gume do infinito",
                URLImagemItem = "https://unbiased-gamer.com/wp-content/uploads/2021/12/Gume_do_Infinito-300x300.png",
                Tipo = TipoItemEnum.Físico,
                Preco = 3400
            },
            new ItensModel
            {
                Id = 8,
                Nome = "Manopla dos Glacinatas",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9bfd9768726a2365/636c73198b1a6210a79a0b47/111522_Patch_12_22_Notes_Iceborn_Gauntlet.png",
                Tipo = TipoItemEnum.Tanque,
                Preco = 2700
            },
            new ItensModel
            {
                Id = 9,
                Nome = "Capuz da Morte de Rabadon",
                URLImagemItem = "https://pbs.twimg.com/media/E4_HJB4XIAM9XEq.jpg",
                Tipo = TipoItemEnum.Mágico,
                Preco = 3600
            },
            new ItensModel
            {
                Id = 10,
                Nome = "Dançarina Fantasma",
                URLImagemItem = "https://pm1.narvii.com/6601/6e79bf4d699ed9c08bbe9702a0151cebb49b7c1a_hq.jpg",
                Tipo = TipoItemEnum.Velocidade_De_Ataque,
                Preco = 2600
            },
            new ItensModel
            {
                Id = 11,
                Nome = "Colhedor de Essência",
                URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt1c833ea361139340/5fa1f019432f517518d427b8/3508_Marksman_T3_EssenceReaver.png",
                Tipo = TipoItemEnum.Físico,
                Preco = 2800
            },
            new ItensModel
            {
                Id = 12,
                Nome = "Quimiotanque Turbo",
                URLImagemItem = "https://pbs.twimg.com/media/ErLau-GXcAAmgje.jpg",
                Tipo = TipoItemEnum.Tanque,
                Preco = 2800
            }
        );
    }
    }
}

