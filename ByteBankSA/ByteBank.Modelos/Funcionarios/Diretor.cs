using ByteBank.Modelos.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public class Diretor : FuncionarioAutenticavel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        public Diretor(string cpf) : base(5000, cpf)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal protected override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
