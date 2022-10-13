using bytebank.Modelos.Conta;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ExemplosCodigos
    {
        #region Exemplo Arrays em C#
        void TestaArrayInt()
        {
            int[] idades = new int[5];
            idades[0] = 30;
            idades[1] = 40;
            idades[2] = 17;
            idades[3] = 21;
            idades[4] = 18;

            Console.WriteLine($"Tamanho do Array {idades.Length}");

            int acumulador = 0;
            for(int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                acumulador += idade;
                Console.WriteLine($"Indice [{i}] = {idades[i]}");
            }
            double media = acumulador / idades.Length;

            Console.WriteLine($"Media de idades = {media}");
        }

        void TestaBuscarPalavra()
        {
            string?[] arrayPalavras = new string[5];

            for(int i = 0; i < arrayPalavras.Length; i++)
            {
                Console.Write($"Digite palavra {i + 1}: ");
                arrayPalavras[i] = Console.ReadLine();
            }

            Console.Write("Digite palavra a ser encontrada: ");
            var busca = Console.ReadLine();

            foreach(var palavra in arrayPalavras)
            {
                if(palavra != null)
                {
                    if(palavra.ToUpper().Equals(busca?.ToUpper()))
                    {
                        Console.WriteLine($"Palavra encontrada = {busca}.");
                        break;
                    }
                }
            }
        }

        Array RetornaArray()
        {
            Array? amostra = Array.CreateInstance(typeof(double), 5);
            amostra.SetValue(5.9, 0);
            amostra.SetValue(1.8, 1);
            amostra.SetValue(7.1, 2);
            amostra.SetValue(10, 3);
            amostra.SetValue(6.9, 4);
            return amostra;
        }

        void TestaMediana(Array array)
        {
            if((array == null) || (array.Length == 0))
                Console.WriteLine("Array para caulculo da mediana esta vazio ou nulo.");

            double[]? numerosOrdenados = (double[]?) array?.Clone();

            Array.Sort(numerosOrdenados);

            int tamanho = numerosOrdenados.Length;
            int meio = tamanho / 2;
            double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio]) / 2;

            Console.WriteLine($"Com base na amostra a mediana = {mediana}");
        }

        void TesteArray()
        {
            int[] valores = { 10, 58, 36, 47 };
            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }

        void TestaArrayDeContasCorrentes()
        {
            ContaCorrente[] listaDeContas = new ContaCorrente[]
            {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-A")
            };

            for(int i = 0; i < listaDeContas.Length; i++)
            {
                ContaCorrente contaAtual = listaDeContas[i];
                Console.WriteLine($"Indice: {i} - Conta: {contaAtual.Conta}");
            }
        }

        void TestaArrayDeContas()
        {
            ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
            listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-A"));

            var contaAndre = new ContaCorrente(963, "123456-X");
            listaDeContas.Adicionar(contaAndre);
            //listaDeContas.ExibirLista();
            //Console.WriteLine("============");
            //listaDeContas.Remover(contaAndre);
            //listaDeContas.ExibirLista();

            for(int i = 0; i < listaDeContas.Tamanho; i++)
            {
                ContaCorrente conta = listaDeContas[i];
                Console.WriteLine($"Indice[{i}] = {conta.Conta}/{conta.Numero_agencia}");
            }
        }
        #endregion
        #region Exemplo Generic
        //public class Generica<T>
        //{
        //    public void MonstrarMensagem(T t)
        //    {
        //        Console.WriteLine($"Exibindo {t}");
        //    }
        //}
        #endregion
        #region Exemplo List
        void TestaList()
        {

            List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
            {
                new ContaCorrente(95, "567987-A"),
                new ContaCorrente(95, "445668-B"),
                new ContaCorrente(95, "778143-C")
            };

            List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
            {
                new ContaCorrente(95, "567978-E"),
                new ContaCorrente(95, "448923-F"),
                new ContaCorrente(95, "982841-G")
            };

            _listaDeContas2.AddRange(_listaDeContas3);
            _listaDeContas2.Reverse();

            for(int i = 0; i < _listaDeContas2.Count; i++)
            {
                Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
            }

            Console.WriteLine("\n\n");

            var range = _listaDeContas3.GetRange(0, 1);

            for(int i = 0; i < range.Count; i++)
            {
                Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
            }

            Console.WriteLine("\n\n");

            _listaDeContas3.Clear();

            for(int i = 0; i < _listaDeContas3.Count; i++)
            {
                Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
            }

            List<string> nomesDosEscolhidos = new List<string>()
            {
                "Bruce Wayne",
                "Carlos Vilagran",
                "Richard Grayson",
                "Bob Kane",
                "Will Farrel",
                "Lois Lane",
                "General Welling",
                "Perla Letícia",
                "Uxas",
                "Diana Prince",
                "Elisabeth Romanova",
                "Anakin Wayne"
            };

            Console.WriteLine(nomesDosEscolhidos.Contains("Anakin Wayne"));
        }
        #endregion
    }
}
