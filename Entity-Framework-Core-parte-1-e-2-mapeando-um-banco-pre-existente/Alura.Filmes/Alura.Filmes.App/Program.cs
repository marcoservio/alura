using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AluraFilmeContexto())
            {
                context.LogSQLToConsole();

                var idiomas = context.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach (var idioma in idiomas)
                {
                    Console.WriteLine(idioma);

                    foreach (var filme in idioma.FilmesFalados)
                    {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.ReadLine();
        }
    }
}