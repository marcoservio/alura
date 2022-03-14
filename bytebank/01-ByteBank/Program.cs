using System;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar uma instancia da classe -- O OBJETO é criado e sua referência é atribuída à variável contaGabriela
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
