using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

using Humanizer;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(342, 4),
                new ContaCorrente(342, 465),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 290)
            };

            //contas.Sort(); -> Chama a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach(var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, agencia {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Welington",
                "Guilherme",
                "Luana",
                "Juana",
                "Ana",
                "Marco"
            };

            nomes.Sort();

            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);
            //idades.AddRange(new int[] { 1, 2, 3, 9 });
            ListExtensoes.AdicionarVarios(idades, 1, 4324, 12312, 1321, 1, 2, 3);
            idades.AdicionarVarios(31, 312312, 132, 2, 2, 3, 4, 6, 6);

            idades.Remove(5);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for(int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void TestaVar()
        {
            var resultado = SomarVarios(1, 5, 9);
            var conta = new ContaCorrente(312, 3123123);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();
        }

        static void TestaSomarVarios()
        {
            Console.WriteLine(SomarVarios(1, 2, 3, 5, 54564, 45));
            Console.WriteLine(SomarVarios(1, 2, 3, 45));
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for(int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int) listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;

            foreach(int numero in numeros)
            {
                acumulador += numero;
            }

            return acumulador;
        }

        static void SomaNumerosTeste()
        {
            ListaDeContaCorrente teste = new ListaDeContaCorrente();

            int[] m = new int[5];

            m[0] = 1;
            m[1] = 2;
            m[2] = 3;
            m[3] = 4;
            m[4] = 5;

            teste.SomarNumeros(m);
        }

        static void TesteListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 10);

            ContaCorrente contaDoGui = new ContaCorrente(111, 11111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 46546846),
                new ContaCorrente(874, 46546846)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 46546846));
            lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846));
            lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846));
            lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846));
            lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846), new ContaCorrente(874, 46546846));

            for(int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia}/{itemAtual.Numero}");
            }
        }

        static void TestaArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 46546846),
                new ContaCorrente(874, 12335846),
                new ContaCorrente(874, 12335846)
            };

            for(int indice = 0; indice < contas.Length; indice++)
            {
                Console.WriteLine($"Conta {indice} {contas[indice].Numero}");
            }
        }

        static void TesteArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for(int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o arry idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades {media}");
        }

        static void TesteEquals()
        {
            Console.WriteLine("Olá! Mundo");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(132, 31231231);
            object desenvolvedor = new Desenvolvedor("1231231");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado " + contaToString);
            Console.WriteLine(conta);

            Cliente carolos_1 = new Cliente();
            carolos_1.Nome = "Carlos";
            carolos_1.Cpf = "456.456.879.11";
            carolos_1.Profissao = "Designer";

            Cliente carolos_2 = new Cliente();
            carolos_2.Nome = "Carlos";
            carolos_2.Cpf = "456.456.879.11";
            carolos_2.Profissao = "Designer";

            if(carolos_1.Equals(carolos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
        }

        static void TesteString()
        {
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "jkhfaksjdfhsaldjfhad adasda 99169-3119 asjhdajkhdas dfjshfasldfa";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();

            string urlParametros = "http://www.bytebank.com.br/cambio?valor=1500&moedaOrigem=real&moedaDestino=dolar";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string moedaOrigem = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Moeda de Origem: " + moedaOrigem);

            string moedaDestino = extrator.GetValor("moedaDestino");
            Console.WriteLine("Moeda de Destino: " + moedaDestino);

            string valor = extrator.GetValor("VALOR");
            Console.WriteLine("Valor: " + valor);

            Console.ReadLine();

            // Testando replace + tolower 
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(mensagemOrigem.ToLower());

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));

            Console.ReadLine();

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            int indiceInterrogacao = url.IndexOf('?');
            string argumentos = url.Substring(indiceInterrogacao + 1);

            Console.WriteLine(indiceInterrogacao);
            Console.WriteLine(url);
            Console.WriteLine(argumentos);

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);

            int indiceValor = indice + nomeArgumento.Length;

            string valorArgumento = palavra.Substring(indiceValor + 1);
        }

        static void AprendendoDatetime()
        {
            DateTime dataFimPagamento = new DateTime(2022, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(60); //dataFimPagamento - dataCorrente;

            Console.WriteLine("Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca));
        }
    }
}
