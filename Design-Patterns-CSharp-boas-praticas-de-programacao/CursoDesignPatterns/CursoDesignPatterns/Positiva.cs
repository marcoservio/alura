using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Positiva : EstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saque(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if(conta.Saldo < 0)
                conta.EstadoAtual = new Negativa();
        }
    }
}
