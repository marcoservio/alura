using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.MsBuild.Modelos;

namespace Alura.MsBuild.Relatorios
{
    public class RelatorioDePendencias
    {
        IEnumerable<IGrouping<Categoria, Tarefa>> _tarefasPendentes;

        public RelatorioDePendencias(IEnumerable<Tarefa> tarefas)
        {
            _tarefasPendentes = tarefas
                    .Where(t => !t.Concluida)
                    .OrderBy(t => t.DiasParaSerConcluida)
                    .GroupBy(t => t.Categoria);
        }

        public IEnumerable<IGrouping<Categoria, Tarefa>> TarefasPendentes => _tarefasPendentes;
    }
}