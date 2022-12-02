using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            if(orcamento.Valor < 1000.0)
                return orcamento.Valor * 0.05;
            else if(orcamento.Valor >= 1000.0 && orcamento.Valor <= 3000.0)
                return orcamento.Valor * 0.07;
            else
                return (orcamento.Valor * 0.08) + 30;
        }
    }
}
