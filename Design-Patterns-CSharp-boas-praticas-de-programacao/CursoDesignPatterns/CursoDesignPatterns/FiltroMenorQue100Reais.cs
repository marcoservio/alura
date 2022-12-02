using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro)
        {

        }

        public FiltroMenorQue100Reais() : base()
        {

        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach(var item in contas)
            {
                if(item.Saldo < 100)
                    filtrada.Add(item);
            }
            foreach(var item in Proximo(contas))
            {
                filtrada.Add(item);
            }

            return filtrada;
        }
    }
}
