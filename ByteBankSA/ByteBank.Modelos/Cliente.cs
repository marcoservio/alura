using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    /// <summary>
    /// 
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// 
        /// </summary>
        public string _cpf;
        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                //Escrevo minha logica de validação de CPF
                _cpf = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Profissao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)obj;
            Cliente outroCliente = obj as Cliente;

            if(outroCliente == null)
            {
                return false;
            }

            //return Nome == outroCliente.Nome && Cpf == outroCliente.Cpf && Profissao == outroCliente.Profissao;
            return Cpf == outroCliente.Cpf;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
