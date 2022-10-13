using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente
    {
        public string _cpf;

        //prop -- completa -- tab - tab - enter - enter /////// Propriedade //////// Encapsulamento
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
