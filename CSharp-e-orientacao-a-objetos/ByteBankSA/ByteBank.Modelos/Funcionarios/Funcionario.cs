using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public abstract  class Funcionario
    {
        /// <summary>
        /// 
        /// </summary>
        public static int TotalDeFuncionario { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public double Salario { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="salario"></param>
        /// <param name="cpf"></param>
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionario++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpf"></param>
        public Funcionario(string cpf) : this(1500, cpf)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void AumentarSalario();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //Internal + protected é visivel para classes internas e derivadas
        internal protected abstract double GetBonificacao();
    }
}
