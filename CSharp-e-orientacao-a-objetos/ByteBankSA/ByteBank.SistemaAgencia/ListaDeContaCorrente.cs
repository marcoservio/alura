using ByteBank.Modelos;

using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        public int Tamanho 
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrão", int numero = 5)
        {

        }

        public void AdicionarVarios(params ContaCorrente[] itens)
        {
            foreach(ContaCorrente conta in itens)
            {
                Adicionar(conta);
            }
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                if(_itens[i].Equals(item))
                {
                    indiceItem = i;

                    break;
                }
            }
            if(indiceItem != -1)
            {
                for(int i = indiceItem; i < _proximaPosicao - 1; i++)
                {
                    _itens[i] = _itens[i + 1];
                }
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;

            _proximaPosicao++;
        }

        public ContaCorrente GetItemNoIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;

            if(novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            //Array.Copy(sourceArray: _itens, sourceIndex: 4, destinationArray: novoArray, destinationIndex: 2, length: 3);

            for(int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];

                //Console.WriteLine(".");
            }

            _itens = novoArray;
        }

        public void SomarNumeros(int[] numeros)
        {
            for(int i = 0; i < numeros.Length - 1; i += 2)
            {
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i + 1];

                int soma = primeiroNumero + segundoNumero;

                Console.WriteLine($"{primeiroNumero}+{segundoNumero} = {soma}");
            }
        }

        public ContaCorrente this[string texto]
        {
            get
            {
                return null;
            }
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
