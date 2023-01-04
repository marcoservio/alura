using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using System;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AluraFilmeContexto())
            {
                context.LogSQLToConsole();

                foreach (var item in context.Atores)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}