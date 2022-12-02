using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public Filtro()
        {

        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if(OutroFiltro != null)
                return OutroFiltro.Filtra(contas);

            return new List<Conta>();
        }
    }
}
