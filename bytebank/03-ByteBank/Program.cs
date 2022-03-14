using System;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863452;
            Console.WriteLine("Igualdade de tipo de referencia: " + (contaGabriela == contaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;
            Console.WriteLine("Igualdade de tipo valor: " + (idade == idadeMaisUmaVez));

            contaGabriela = contaGabrielaCosta;
            Console.WriteLine(contaGabriela == contaGabrielaCosta);

            contaGabriela.saldo = 300;
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            if(contaGabriela.saldo >= 100)
            {
                contaGabriela.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
