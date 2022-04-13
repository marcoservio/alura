using ByteBank.Modelos.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
