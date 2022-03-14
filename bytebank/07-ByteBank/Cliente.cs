using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ByteBank
{
    public class Cliente
    {
        public string _cpf;
        public string Nome { get; set; }
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
        public string Profissao { get; set; }
    }
}
