using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(456, 455789);
            Console.WriteLine(conta.Saldo);

            conta.Sacar(10);

            Console.ReadLine();
        }
    }
}
