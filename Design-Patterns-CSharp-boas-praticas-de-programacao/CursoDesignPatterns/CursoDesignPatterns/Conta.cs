using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public EstadoDeUmaConta EstadoAtual { get; set; }
        public string  Titular { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
            EstadoAtual = new Positiva();
        }

        public void Deposito(double valor)
        {
            EstadoAtual.Deposito(this, valor);
        }

        public void Saque(double valor)
        {
            EstadoAtual.Saque(this, valor);
        }
    }
}
