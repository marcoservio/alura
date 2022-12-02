using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public interface EstadoDeUmaConta
    {
        void Saque(Conta conta, double valor);
        void Deposito(Conta conta, double valor);
    }
}
