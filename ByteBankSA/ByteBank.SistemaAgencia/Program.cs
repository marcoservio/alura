using System;
using System.Text.RegularExpressions;

using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

using Humanizer;

namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 10);

            ContaCorrente contaDoGui = new ContaCorrente(465, 8795147);
            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));
            lista.Adicionar(new ContaCorrente(874, 46546846));

            lista.Remover(contaDoGui);

            Console.ReadLine();
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
