using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017, 9, 23);
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("d")); //data sem hora
            Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Console.WriteLine(data.ToString("d", new CultureInfo("en-US")));
            Console.WriteLine(data.ToString("dd/MM")); //M maiusculo porque o m minisculo é o m da hora
            Console.WriteLine(data.ToString("dd/MM/yy")); 

            data = new DateTime(2017, 9, 23, 13, 14, 15, 987);
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("HH:mm")); //h minusculo padrão americano
            Console.WriteLine(data.ToString("HH:mm:ss.fff")); //f milisegundos

            Console.WriteLine(data.ToString("D")); //Data por extenso
            Console.WriteLine(data.ToString("m")); //Data por extenso resumida
            Console.WriteLine(data.ToString("Y")); //Data por extenso sem o dia

            Console.WriteLine(data.ToString("G")); //Data geral
            Console.WriteLine(data.ToString("g")); //Data geral sem segundos

            Console.WriteLine(data.ToString("O"));
            Console.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));

            Console.WriteLine(data.ToString("t")); //Horario resumido
            Console.WriteLine(data.ToString("T")); //Horario completo

            Console.ReadKey();
        }
    }
}
