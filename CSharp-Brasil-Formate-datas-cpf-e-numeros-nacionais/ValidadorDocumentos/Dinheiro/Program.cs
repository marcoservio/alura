using Caelum.Stella.CSharp.Vault;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = 10.00;
            Console.WriteLine(money.ToString());

            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Console.WriteLine(total.ToString());

            decimal minuendo = 20m;
            decimal subtraendo = 15m;
            Money diferenca = minuendo - subtraendo;
            Console.WriteLine(diferenca.ToString());

            Money euro = new Money(Currency.EUR, 1000);
            Console.WriteLine(euro.ToString());

            Money dolar = new Money(Currency.USD, 1000);
            Console.WriteLine(dolar.ToString());
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(dolar.ToString());
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            //Erro não pode somar moedas diferentes.
            ///Money somaMoedasDiferentes = euro + dolar;
            //Console.WriteLine(somaMoedasDiferentes.ToString());

            Console.ReadKey();
        }
    }
}
