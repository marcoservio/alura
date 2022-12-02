using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Negativa : EstadoDeUmaConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if(conta.Saldo > 0) conta.EstadoAtual = new Positiva();
        }

        public void Saque(Conta conta, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }
    }
}
