using System;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Referencia do objeto do tipo cliente --- Objeto cliente da gabriela --- gabriela é uma referencia pro objeto
            // na memoria --- gabriela é um objeto --- uma referencia
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "434.562.878.20";
            //gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            // Composição de Classe
            //conta.titular = gabriela;
            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "434.562.878.20";
            //conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é NULL");
            }

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
