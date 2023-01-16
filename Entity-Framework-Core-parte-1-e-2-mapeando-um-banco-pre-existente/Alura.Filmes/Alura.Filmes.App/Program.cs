using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
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

                var sql = "INSERT INTO language (name) VALUES ('teste 1'), ('teste 2'), ('teste 3')";
                var registro = context.Database.ExecuteSqlCommand(sql);
                Console.WriteLine($"O total de registros afetados é {registro}");

                var deleteSql = "DELETE FROM language WHERE name LIKE 'test%'";
                registro = context.Database.ExecuteSqlCommand(deleteSql);
                Console.WriteLine($"O total de registros afetados é {registro}");
            }
        }

        static void StoredProcedures(DbContext context)
        {
            var categ = "Action";

            var paramCateg = new SqlParameter("category_name", categ);
            var paramTotal = new SqlParameter
            {
                ParameterName = "@total_actors",
                Size = 4,
                Direction = System.Data.ParameterDirection.Output
            };

            context.Database
                .ExecuteSqlCommand("execute total_actors_from_given_category @category_name, @total_actors OUT",
                paramCateg,
                paramTotal);

            Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}");
        }
    }
}