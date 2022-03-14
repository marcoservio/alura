using System;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for(int mes = 1; mes <= 12; mes++)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.005); // Fator de rendimento
                //valorInvestido *= * 1.005; // (100/100 + 0,36/100) * valorInvestido -> (1 + 0,0036) * valorInvestido
                Console.WriteLine("Após " + mes + " meses, você terá R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
