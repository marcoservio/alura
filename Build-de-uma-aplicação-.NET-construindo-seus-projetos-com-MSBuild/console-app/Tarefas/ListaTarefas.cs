using System;
using System.Collections.Generic;
using System.Linq;
using Alura.MsBuild.Modelos;
using Alura.MsBuild.Relatorios;

namespace Alura.MsBuild.Tarefas
{
    public class ListaTarefas
    {
        static void Main()
        {
            var estudo = new Categoria("Estudo");
            var lazer = new Categoria("Lazer");
            var financas = new Categoria("Finanças");

            var tarefas = new List<Tarefa>
            {
				// lazer
				new Tarefa("Ir à praia", lazer, DateTime.Now.AddDays(3)),
                new Tarefa("Aniversário do Pedro", lazer, DateTime.Now.AddMonths(1)),
                new Tarefa("Almoço de família", lazer, DateTime.Now.AddDays(7)),
				
				// estudo 
				new Tarefa("Estudar MsBuild", estudo, DateTime.Now.AddMonths(3)),
                new Tarefa("Estudar Orientação a Objetos", estudo, DateTime.Now.AddDays(7)),
                new Tarefa("Prova de Biologia", estudo, DateTime.Now.AddDays(5)),
                new Tarefa("ENEM", estudo, DateTime.Now.AddYears(1)),
                new Tarefa("Estudar violão", estudo, DateTime.Now.AddYears(3)),
                new Tarefa("Revisar Geopolítica", estudo, DateTime.Now.AddMonths(4)),
				
				// finanças
				new Tarefa("Quitar CC", financas, DateTime.Now.AddMonths(1)),
                new Tarefa("Pagar Luz ", financas, DateTime.Now.AddDays(8)),
                new Tarefa("Pagar Internet", financas, DateTime.Now.AddDays(15)),
            };

            var relatorio = new RelatorioDePendencias(tarefas);

            foreach (var categ in relatorio.TarefasPendentes)
            {
                Console.WriteLine("\n" + categ.Key);
                foreach (var tarefa in categ.OrderBy(t => t.DiasParaSerConcluida))
                {
                    Console.WriteLine(tarefa);
                }
            }
        }
    }
}