using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Conservador : Investidor
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.08;
        }
    }
}
