using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Sistemas
{
    /// <summary>
    /// 
    /// </summary>
    public class SistemaInterno
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcionario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem-Vindo ao sitema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
