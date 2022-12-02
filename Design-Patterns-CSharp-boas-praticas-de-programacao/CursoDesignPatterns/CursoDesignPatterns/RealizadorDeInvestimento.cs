using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RealizadorDeInvestimento
    {
        public void RealizaCalculo(Conta conta, Investidor investidor)
        {
            double valor = investidor.Calcula(conta);
            conta.Deposita(valor * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
