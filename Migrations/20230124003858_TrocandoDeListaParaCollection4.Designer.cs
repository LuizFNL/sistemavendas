﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistemavendas.Data;

#nullable disable

namespace sistemavendas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230124003858_TrocandoDeListaParaCollection4")]
    partial class TrocandoDeListaParaCollection4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sistemavendas.Models.ItensModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<string>("URLImagemItem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Itens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Eco de Luden",
                            Preco = 3200m,
                            Tipo = 0,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9a3499b1ce0e8a47/5fa1f08567a7c354926051d4/6655_Mage_T4_LudensTempest.png"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Mata-Cráquens",
                            Preco = 3400m,
                            Tipo = 2,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltcb7a3c892dac6359/5fa1f08ccb9eba781f087dc8/6672_Marksman_T4_KrakenSlayer.png"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Crepúsculo de Draktharr",
                            Preco = 3100m,
                            Tipo = 1,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt56608d19bafa7adf/5fa1f08c432f517518d427cc/6691_Assassin_T4_DuskbladeOfDraktharr.png"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Armadura de Warmog",
                            Preco = 3000m,
                            Tipo = 3,
                            URLImagemItem = "https://pbs.twimg.com/media/E4-p9h-WEAcvt_u.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Colhedor Noturno",
                            Preco = 3200m,
                            Tipo = 0,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltaf02a9ed2a06c61d/5fa1f06f6178a9645452d2d4/4636_Mage_T4_NightHarvester.png"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Arco-escudo Imortal",
                            Preco = 3400m,
                            Tipo = 2,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blteaebe960fa64ee65/5fa1f0936178a9645452d2dc/6673_Marksman_T4_ImmortalShieldbow.png"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Gume do infinito",
                            Preco = 3400m,
                            Tipo = 1,
                            URLImagemItem = "https://unbiased-gamer.com/wp-content/uploads/2021/12/Gume_do_Infinito-300x300.png"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Manopla dos Glacinatas",
                            Preco = 2700m,
                            Tipo = 3,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9bfd9768726a2365/636c73198b1a6210a79a0b47/111522_Patch_12_22_Notes_Iceborn_Gauntlet.png"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Capuz da Morte de Rabadon",
                            Preco = 3600m,
                            Tipo = 0,
                            URLImagemItem = "https://pbs.twimg.com/media/E4_HJB4XIAM9XEq.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Dançarina Fantasma",
                            Preco = 2600m,
                            Tipo = 2,
                            URLImagemItem = "https://pm1.narvii.com/6601/6e79bf4d699ed9c08bbe9702a0151cebb49b7c1a_hq.jpg"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Colhedor de Essência",
                            Preco = 2800m,
                            Tipo = 1,
                            URLImagemItem = "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt1c833ea361139340/5fa1f019432f517518d427b8/3508_Marksman_T3_EssenceReaver.png"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Quimiotanque Turbo",
                            Preco = 2800m,
                            Tipo = 3,
                            URLImagemItem = "https://pbs.twimg.com/media/ErLau-GXcAAmgje.jpg"
                        });
                });

            modelBuilder.Entity("sistemavendas.Models.ItensVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EmAberto")
                        .HasColumnType("bit");

                    b.Property<int>("ItensModelId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("VendaModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItensModelId");

                    b.HasIndex("VendaModelId");

                    b.ToTable("ItensVendas");
                });

            modelBuilder.Entity("sistemavendas.Models.VendaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("sistemavendas.Models.ItensVenda", b =>
                {
                    b.HasOne("sistemavendas.Models.ItensModel", "ItensModel")
                        .WithMany()
                        .HasForeignKey("ItensModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sistemavendas.Models.VendaModel", null)
                        .WithMany("ItensVenda")
                        .HasForeignKey("VendaModelId");

                    b.Navigation("ItensModel");
                });

            modelBuilder.Entity("sistemavendas.Models.VendaModel", b =>
                {
                    b.Navigation("ItensVenda");
                });
#pragma warning restore 612, 618
        }
    }
}
