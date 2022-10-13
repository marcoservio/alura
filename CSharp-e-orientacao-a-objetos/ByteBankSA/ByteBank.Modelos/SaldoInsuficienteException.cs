using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    /// <summary>
    /// 
    /// </summary>
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        /// <summary>
        /// 
        /// </summary>
        public double Saldo { get; }
        /// <summary>
        /// 
        /// </summary>
        public double ValorSaque { get; }

        /// <summary>
        /// 
        /// </summary>
        public SaldoInsuficienteException()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saldo"></param>
        /// <param name="valorSaque"></param>
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        /// <param name="excecaoInterna"></param>
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
             : base(mensagem, excecaoInterna)
        {

        }
    }
}
