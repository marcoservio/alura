using System;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaGabriela = new ContaCorrente(867, 86712540);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
