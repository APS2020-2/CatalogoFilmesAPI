﻿// <auto-generated />
using CatalogoFilmesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatalogoFilmesAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("CatalogoFilmesAPI.Models.Diretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Diretores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "David Fincher nasceu em 1962 em Denver, Colorado, e foi criado no condado de Marin, Califórnia. Quando tinha 18 anos, foi trabalhar para John Korty na Korty Films em Mill Valley. Posteriormente, trabalhou na ILM (Industrial Light and Magic) de 1981-1983. Fincher deixou a ILM para dirigir comerciais de TV e videoclipes após assinar com N. Lee Lacy em Hollywood. Ele fundou a Propaganda em 1987 com seus colegas diretores Dominic Sena , Greg Gold e Nigel Dick . Fincher dirigiu comerciais de TV para clientes que incluem Nike, Coca-Cola, Budweiser, Heineken, Pepsi, Levi's, Converse, AT&T e Chanel. Ele dirigiu videoclipes para Madonna , Sting ,The Rolling Stones , Michael Jackson , Aerosmith , George Michael , Iggy Pop , The Wallflowers , Billy Idol , Steve Winwood , The Motels e, mais recentemente, A Perfect Circle .",
                            DataNasc = "28/08/1962",
                            Nome = "David Fincher"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Taika Waititi, também conhecido como Taika Cohen, é natural da região de Raukokore, na costa leste da Nova Zelândia, e é filho de Robin (Cohen), um professor, e de Taika Waiti, um artista e fazendeiro. Seu pai é Maori (Te-Whanau-a-Apanui), e sua mãe é de ascendência judia Ashkenazi, irlandesa, escocesa e inglesa. Taika está envolvido na indústria do cinema há vários anos, inicialmente como ator, e agora se concentra em escrever e dirigir. Two Cars, One Night é o primeiro esforço cinematográfico profissional de Taika e, desde sua conclusão em 2003, ele terminou outro curta Tama Tu sobre um grupo de soldados Maori na Itália durante a 2ª Guerra Mundial. Como artista e comediante, Taika tem sido envolvido em algumas das produções originais mais inovadoras e bem-sucedidas vistas na Nova Zelândia. Ele regularmente faz shows de stand-up em todo o país e em 2004 lançou sua produção solo, Taika's Incredible Show. Em 2005, ele encenou a sequência, Taika's Incrediblerer Show. Como ator, Taika foi aclamado pela crítica por suas habilidades cômicas e dramáticas. Em 2000, ele foi indicado para Melhor Ator no Nokia Film Awards por seu papel no filme Scarfies dos irmãos Sarkies.",
                            DataNasc = "16/08/1975",
                            Nome = "Taika Waititi"
                        });
                });

            modelBuilder.Entity("CatalogoFilmesAPI.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("DiretorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Duracao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GeneroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdiomaOriginal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DiretorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = 1999,
                            DataLancamento = "29/10/1999",
                            Descricao = "Um trabalhador de escritório e um fabricante de sabonetes que cuidam do diabo formam um clube de luta clandestino que evolui para algo muito maior.",
                            DiretorId = 1,
                            Duracao = 139,
                            GeneroId = 1,
                            IdiomaOriginal = "EN",
                            Poster = "",
                            Titulo = "Clube da Luta"
                        },
                        new
                        {
                            Id = 2,
                            Ano = 2019,
                            DataLancamento = "06/02/2019",
                            Descricao = "Um jovem parte do exército nazi, descobre que sua mãe esconde uma jovem judia na sua casa.",
                            DiretorId = 2,
                            Duracao = 108,
                            GeneroId = 2,
                            IdiomaOriginal = "EN",
                            Poster = "",
                            Titulo = "Jojo Rabbit"
                        });
                });

            modelBuilder.Entity("CatalogoFilmesAPI.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Drama"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Comédia"
                        });
                });

            modelBuilder.Entity("CatalogoFilmesAPI.Models.Filme", b =>
                {
                    b.HasOne("CatalogoFilmesAPI.Models.Diretor", "Diretor")
                        .WithMany("Filmes")
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CatalogoFilmesAPI.Models.Genero", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
