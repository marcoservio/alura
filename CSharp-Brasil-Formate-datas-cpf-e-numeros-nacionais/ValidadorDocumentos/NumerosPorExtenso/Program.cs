using Caelum.Stella.CSharp.Inwords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Console.WriteLine(extenso);

            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Console.WriteLine(extenso);

            Console.WriteLine(extenso + " reais");

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Console.WriteLine(extensoBRL);

            valor = 1532987.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Console.WriteLine(extensoBRL);

            valor = 1.01;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Console.WriteLine(extensoBRL);

            Console.ReadKey();
        }
    }
}
