using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
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
    }
}
