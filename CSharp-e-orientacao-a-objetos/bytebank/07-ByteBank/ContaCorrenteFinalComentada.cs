using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ByteBank
{
    public class ContaCorrente1
    {
        //prop -- completa -- tab - tab - enter - enter /////// Propriedade //////// Encapsulamento
        public Cliente Titular { get; set; }
        // static porque ela pertence a todos dessa classe = todos os objetos compartilha dessas informações
        // caracteristica de classe não dos objetos
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        // Convenção de escrita de variaveis _titular quando for privada
        private double _saldo = 100;
        // Propriedade
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //public void SetSaldo(double saldo)
        //{
        //    if(saldo < 0)
        //    {
        //        return;
        //    }

        //    this.saldo = saldo;
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public ContaCorrente1(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            // this -> Verifica qual instancia esta chamando
            if(_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        // void -> Função sem retorno -- Metodo quando não retorna / Função quando retorna -> Mas o dois nomes são validos
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);

            return true;
        }
    }
}