using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTunes
{
    class Program
    {
        static void Main(string[] args)
        {
            var generos = new List<Genero>
            {
                new Genero{ Id = 1, Nome = "Rock" },
                new Genero{ Id = 2, Nome = "Reggae" },
                new Genero{ Id = 3, Nome = "Rock Progressivo" },
                new Genero{ Id = 4, Nome = "Punk Rock" },
                new Genero{ Id = 5, Nome = "Classica" }
            };

            foreach (var item in generos)
            {
                if (item.Nome.Contains("Rock"))
                    Console.WriteLine(item);
            }

            var query = from g in generos
                        where g.Nome.Contains("Rock")
                        select g;

            Console.WriteLine();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            var musicas = new List<Musica>
            {
                new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1},
                new Musica { Id = 2, Nome = "I Short the Sheriff", GeneroId = 2},
                new Musica { Id = 3, Nome = "Danubio Azul", GeneroId = 5}
            };

            var musicaQuery = from m in musicas
                              join g in generos on m.GeneroId equals g.Id
                              select new { m, g };

            Console.WriteLine();
            foreach (var item in musicaQuery)
            {
                Console.WriteLine($"{item.m.Id} - {item.m.Nome} - {item.g.Nome}");
            }

            Console.ReadKey();
        }
    }

    class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome}";
        }
    }

    class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome} - {GeneroId}";
        }
    }
}
