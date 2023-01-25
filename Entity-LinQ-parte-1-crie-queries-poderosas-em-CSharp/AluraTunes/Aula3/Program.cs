using Aula3.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }

        private static void MedianaLinq()
        {
            using (var context = new AluraTunesEntities())
            {
                var vendaMedia = context.NotaFiscals.Average(n => n.Total);

                Console.WriteLine($"Venda Media: {vendaMedia}");

                var query = from nf in context.NotaFiscals
                            select nf.Total;

                decimal mediana = Mediana(query);

                Console.WriteLine($"Mediana: {mediana}");

                var vendaMediana = context.NotaFiscals.Mediana(n => n.Total);

                Console.WriteLine($"Mediana (com metodo de extensão): {vendaMediana}");
            }
        }

        private static decimal Mediana(IQueryable<decimal> query)
        {
            var queryOrdenada = query.OrderBy(t => t);

            var elementoCentral_1 = queryOrdenada.Skip(query.Count() / 2).First();

            var elementoCentral_2 = queryOrdenada.Skip((query.Count() -1) / 2).First();

            var mediana = (elementoCentral_1 + elementoCentral_2) / 2;
            return mediana;
        }

        private static void MaxMinAverage()
        {
            using (var context = new AluraTunesEntities())
            {
                context.Database.Log = Console.WriteLine;

                var maiorVenda = context.NotaFiscals.Max(n => n.Total);
                var menorVenda = context.NotaFiscals.Min(n => n.Total);
                var vendaMedia = context.NotaFiscals.Average(n => n.Total);

                Console.WriteLine($"A maior venda é de R${maiorVenda}");
                Console.WriteLine($"A menor venda é de R${menorVenda}");
                Console.WriteLine($"A venda media é de R${vendaMedia}");

                var vendas = (from nf in context.NotaFiscals
                              group nf by 1 into agrupado
                              select new
                              {
                                  marioVenda = agrupado.Max(n => n.Total),
                                  menorVenda = agrupado.Min(n => n.Total),
                                  vendaMedia = agrupado.Average(n => n.Total)
                              }).Single();

                Console.WriteLine($"A maior venda é de R${vendas.marioVenda}");
                Console.WriteLine($"A menor venda é de R${vendas.menorVenda}");
                Console.WriteLine($"A venda media é de R${vendas.vendaMedia}");
            }
        }

        private static void GroupBy()
        {
            using (var context = new AluraTunesEntities())
            {
                var query = from inf in context.ItemNotaFiscals
                            where inf.Faixa.Album.Artista.Nome == "Led Zeppelin"
                            group inf by inf.Faixa.Album into agrupado
                            let vendasPorAlbum = agrupado.Sum(a => a.Quantidade * a.PrecoUnitario)
                            orderby vendasPorAlbum descending
                            select new
                            {
                                TituloDoAlbum = agrupado.Key.Titulo,
                                TotalPorAlbum = vendasPorAlbum
                            };

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.TituloDoAlbum.PadRight(40)}\t{item.TotalPorAlbum}");
                }
            }
        }

        private static void TotalizandoPorArtista()
        {
            using (var context = new AluraTunesEntities())
            {
                var query = from inf in context.ItemNotaFiscals
                            where inf.Faixa.Album.Artista.Nome == "Led Zeppelin"
                            select new { totalDoItem = inf.Quantidade * inf.PrecoUnitario };

                //foreach (var item in query)
                //{
                //    Console.WriteLine($"{item.totalDoItem}");
                //}

                var totalDoArtista = query.Sum(q => q.totalDoItem);

                Console.WriteLine($"Total do artista: R${totalDoArtista}");
            }
        }

        private static void CountFaixas()
        {
            using (var context = new AluraTunesEntities())
            {
                var query = from f in context.Faixas
                            where f.Album.Artista.Nome == "Led Zeppelin"
                            select f;

                //var quantidade = query.Count();

                //Console.WriteLine($"Led Zeppelin tem {quantidade} músicas no banco de dados");

                var quantidade = context.Faixas.Count(f => f.Album.Artista.Nome == "Led Zeppelin");

                Console.WriteLine($"Led Zeppelin tem {quantidade} músicas no banco de dados");
            }
        }

        private static void GetFaixas(AluraTunesEntities context, string buscaArtista, string buscaAlbum)
        {
            var query = from f in context.Faixas
                        where f.Album.Artista.Nome.Contains(buscaArtista)
                        && (!string.IsNullOrEmpty(buscaAlbum) ? f.Album.Titulo.Contains(buscaAlbum) : true)
                        orderby f.Album.Titulo, f.Nome descending
                        select f;

            //if (!string.IsNullOrEmpty(buscaAlbum))
            //    query = query.Where(q => q.Album.Titulo.Contains(buscaAlbum));

            //query = query.OrderBy(q => q.Album.Titulo).ThenByDescending(q => q.Nome);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Album.Titulo.PadRight(40)} - {item.Nome}");
            }
        }

        private static void ArtistaAlbum()
        {
            using (var context = new AluraTunesEntities())
            {
                var textoBusca = "Led";

                //Com Join
                var query = from a in context.Artistas
                            join alb in context.Albums
                            on a.ArtistaId equals alb.ArtistaId
                            where a.Nome.Contains(textoBusca)
                            select new
                            {
                                NomeArtista = a.Nome,
                                NomeAlbum = alb.Titulo
                            };

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.NomeArtista} - {item.NomeAlbum}");
                }

                var query2 = context.Artistas.Where(a => a.Nome.Contains(textoBusca));

                Console.WriteLine();
                foreach (var item in query2)
                {
                    Console.WriteLine(item);
                }

                //Sem Join
                var query3 = from alb in context.Albums
                             where alb.Artista.Nome.Contains(textoBusca)
                             select new
                             {
                                 NomeArtista = alb.Artista.Nome,
                                 NomeAlbum = alb.Titulo
                             };

                Console.WriteLine();
                foreach (var item in query3)
                {
                    Console.WriteLine($"{item.NomeArtista} - {item.NomeAlbum}");
                }
            }
        }

        private static void FaixaEGenero()
        {
            using (var context = new AluraTunesEntities())
            {
                var query = from g in context.Generos
                            select g;

                context.Database.Log = Console.WriteLine;

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }

                var faixaEgenero = from g in context.Generos
                                   join f in context.Faixas
                                   on g.GeneroId equals f.GeneroId
                                   select new { f, g };

                faixaEgenero = faixaEgenero.Take(10);

                context.Database.Log = Console.WriteLine;

                Console.WriteLine();
                foreach (var item in faixaEgenero)
                {
                    Console.WriteLine($"{item.f.Nome} - {item.g.Nome}");
                }
            }
        }
    }

    static class LinqExtension
    {
        public static decimal Mediana<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            var funcSeletor = selector.Compile();

            var queryOrdenada = source.Select(funcSeletor).OrderBy(t => t);

            var elementoCentral_1 = queryOrdenada.Skip(source.Count() / 2).First();

            var elementoCentral_2 = queryOrdenada.Skip((source.Count() - 1) / 2).First();

            var mediana = (elementoCentral_1 + elementoCentral_2) / 2;

            return mediana;
        }
    }
}
