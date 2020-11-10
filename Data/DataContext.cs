using System.Collections.Generic;
using CatalogoFilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoFilmesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Genero> Generos { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Diretor> Diretores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Genero>().HasData(
                new List<Genero>(){
                    new Genero(){
                        Id = 1,
                        Nome = "Drama"
                    },
                    new Genero(){
                        Id = 2,
                        Nome = "Comédia"
                    },
                    new Genero(){
                        Id = 3,
                        Nome = "Terror"
                    }
                }
            );

            builder.Entity<Filme>().HasData(
                new List<Filme>(){
                    new Filme(){
                        Id = 1,
                        Titulo = "Clube da Luta",
                        Duracao = 139,
                        DataLancamento = "29/10/1999",
                        Descricao = "Um trabalhador de escritório e um fabricante de sabonetes que cuidam do diabo formam um clube de luta clandestino que evolui para algo muito maior.",
                        IdiomaOriginal = "EN",
                        Poster = "",
                        DiretorId = 1,
                        GeneroId = 1
                    },
                    new Filme(){
                        Id = 2,
                        Titulo = "Jojo Rabbit",
                        Duracao = 108,
                        DataLancamento = "06/02/2019",
                        Descricao = "Um jovem parte do exército nazi, descobre que sua mãe esconde uma jovem judia na sua casa.",
                        IdiomaOriginal = "EN",
                        Poster = "",
                        DiretorId = 2,
                        GeneroId = 2
                    }
                }
            );

            builder.Entity<Diretor>().HasData(
                new List<Diretor>(){
                    new Diretor(){
                        Id = 1,
                        Nome = "David Fincher",
                        Bio = "David Fincher nasceu em 1962 em Denver, Colorado, e foi criado no condado de Marin, Califórnia. Quando tinha 18 anos, foi trabalhar para John Korty na Korty Films em Mill Valley. Posteriormente, trabalhou na ILM (Industrial Light and Magic) de 1981-1983. Fincher deixou a ILM para dirigir comerciais de TV e videoclipes após assinar com N. Lee Lacy em Hollywood. Ele fundou a Propaganda em 1987 com seus colegas diretores Dominic Sena , Greg Gold e Nigel Dick . Fincher dirigiu comerciais de TV para clientes que incluem Nike, Coca-Cola, Budweiser, Heineken, Pepsi, Levi's, Converse, AT&T e Chanel. Ele dirigiu videoclipes para Madonna , Sting ,The Rolling Stones , Michael Jackson , Aerosmith , George Michael , Iggy Pop , The Wallflowers , Billy Idol , Steve Winwood , The Motels e, mais recentemente, A Perfect Circle .",
                        DataNasc = "28/08/1962",
                        Imagem = ""
                    },
                    new Diretor(){
                        Id = 2,
                        Nome = "Taika Waititi",
                        Bio = "Taika Waititi, também conhecido como Taika Cohen, é natural da região de Raukokore, na costa leste da Nova Zelândia, e é filho de Robin (Cohen), um professor, e de Taika Waiti, um artista e fazendeiro. Seu pai é Maori (Te-Whanau-a-Apanui), e sua mãe é de ascendência judia Ashkenazi, irlandesa, escocesa e inglesa. Taika está envolvido na indústria do cinema há vários anos, inicialmente como ator, e agora se concentra em escrever e dirigir. Two Cars, One Night é o primeiro esforço cinematográfico profissional de Taika e, desde sua conclusão em 2003, ele terminou outro curta Tama Tu sobre um grupo de soldados Maori na Itália durante a 2ª Guerra Mundial. Como artista e comediante, Taika tem sido envolvido em algumas das produções originais mais inovadoras e bem-sucedidas vistas na Nova Zelândia. Ele regularmente faz shows de stand-up em todo o país e em 2004 lançou sua produção solo, Taika's Incredible Show. Em 2005, ele encenou a sequência, Taika's Incrediblerer Show. Como ator, Taika foi aclamado pela crítica por suas habilidades cômicas e dramáticas. Em 2000, ele foi indicado para Melhor Ator no Nokia Film Awards por seu papel no filme Scarfies dos irmãos Sarkies.",
                        DataNasc = "16/08/1975",
                        Imagem = ""
                    },
                    new Diretor(){
                        Id = 3,
                        Nome = "John R. Leonetti",
                        Bio = "John R. Leonetti nasceu em 4 de julho de 1956 na Califórnia, EUA, como John Robert Leonetti. É conhecido pelos seus trabalhos sobre Annabelle (2014), Invocação do Mal (2013) e Sobrenatural: Capítulo 2 (2013).",
                        DataNasc = "04/06/1956",
                        Imagem = ""
                    },
                    new Diretor(){
                        Id = 4,
                        Nome = "Oliver Parker",
                        Bio = "Oliver Parker nasceu em 6 de setembro de 1960 em Londres, Inglaterra. É ator e diretor, conhecido por O Retorno de Johnny English (2011), Othello (1995) e Armadilhas do Coração (2002).",
                        DataNasc = "06/09/1960",
                        Imagem = ""
                    },
                    new Diretor(){
                        Id = 5,
                        Nome = "Darren Aronofsky",
                        Bio = "Darren Aronofsky nasceu em 12 de fevereiro de 1969, no Brooklyn, Nova York. Na infância, Darren sempre foi artístico: adorava filmes clássicos e, na adolescência, até passou um tempo fazendo grafite. Após o colegial, Darren foi para a Universidade de Harvard para estudar cinema (live-action e animação). Ele ganhou vários prêmios de cinema depois de concluir seu filme de tese sênior, Supermarket Sweep, estrelado por Sean Gullette , que se tornou finalista do National Student Academy Award. Aronofsky só fez um longa-metragem cinco anos depois, em fevereiro de 1996, quando começou a criar o conceito de Pi (1998). Depois do roteiro de Darren para Pi(1998) recebeu ótimas reações de amigos, iniciou a produção. O filme reuniu Aronofsky com Gullette, que desempenhou o papel principal. Isso seguiu para outros sucessos, como Réquiem para um Sonho (2000), O Lutador (2008) e Cisne Negro (2010). Mais recentemente, concluiu os filmes Noé (2014) e Mãe! (2017).",
                        DataNasc = "12/02/1969",
                        Imagem = ""
                    }
                }
            );
        }
    }
}