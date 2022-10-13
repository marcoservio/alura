using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public class Designer : Funcionario
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        public Designer(string cpf) : base(3000, cpf)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
