using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int ano = 1; ano <= 5; ano++)
            {
                for(int mes = 1; mes <= 12; mes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento, você tera R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
