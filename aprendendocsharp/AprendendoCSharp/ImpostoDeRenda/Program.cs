using System;

namespace ImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3751.01 ;

            if(salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ 142");
            }
            else if(salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }
            else if(salario >= 3751.01 && salario <= 4664.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }

            Console.ReadLine();
        }
    }
}
