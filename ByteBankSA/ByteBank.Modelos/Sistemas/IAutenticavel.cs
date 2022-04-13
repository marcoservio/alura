using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Sistemas
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAutenticavel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
        bool Autenticar(string senha);
    }
}
