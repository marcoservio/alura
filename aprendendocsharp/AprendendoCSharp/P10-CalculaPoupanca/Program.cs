using System;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvertido = 1000;
            int mes = 1;

            while(mes <= 12)
            {
                // 0.36% = 0.0036 - Divido por 100
                valorInvertido = valorInvertido + valorInvertido * 0.0036;
                Console.WriteLine("Apos " + mes + " mês, você terá R$" + valorInvertido);

                //mes = mes + 1;
                //mes += 1;
                mes++;
            }

            Console.ReadLine();
        }
    }
}
