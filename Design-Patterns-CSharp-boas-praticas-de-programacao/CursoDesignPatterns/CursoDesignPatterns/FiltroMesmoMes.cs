using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes()
        {
        }

        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();

            foreach(Conta c in contas)
            {
                if(c.DataAbertura.Month == DateTime.Now.Month &&
                  c.DataAbertura.Year == DateTime.Now.Year)
                {
                    filtrada.Add(c);
                }
            }

            foreach(Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
