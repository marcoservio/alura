using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Modelos. Funcionarios;

namespace ByteBank.Modelos
{
    /// <summary>
    /// 
    /// </summary>
    public class GerenciadorBonificacao
    {
        /// <summary>
        /// 
        /// </summary>
        private double _totalBonificacao;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcionario"></param>
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
