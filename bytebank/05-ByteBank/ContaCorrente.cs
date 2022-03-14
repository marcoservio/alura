using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            // this -> Verifica qual instancia esta chamando
            if(this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        // void -> Função sem retorno -- Metodo quando não retorna / Função quando retorna -> Mas o dois nomes são validos
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);

            return true;
        }
    }
}