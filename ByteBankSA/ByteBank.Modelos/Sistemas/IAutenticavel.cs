using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
