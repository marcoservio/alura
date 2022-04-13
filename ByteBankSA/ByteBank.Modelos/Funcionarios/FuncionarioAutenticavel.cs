using ByteBank.Modelos.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Funcionarios
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        /// <summary>
        /// 
        /// </summary>
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        /// <summary>
        /// 
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="salario"></param>
        /// <param name="cpf"></param>
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
