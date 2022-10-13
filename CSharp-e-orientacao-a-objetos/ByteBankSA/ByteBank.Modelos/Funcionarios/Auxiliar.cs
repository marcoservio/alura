using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public class Auxiliar : Funcionario
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
