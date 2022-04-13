using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    /// <summary>
    /// 
    /// </summary>
    public class OperacaoFinanceiraException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public OperacaoFinanceiraException()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem"></param>
        /// <param name="excecaoInterna"></param>
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
