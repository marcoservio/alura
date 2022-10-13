using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsarStreamDeEntrada()
        {
            using(var fluxoDeEntrada = Console.OpenStandardInput())
            using(var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var totalBytes = 0;
                var buffer = new byte[1024];

                while(totalBytes <= 1024)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    totalBytes += bytesLidos;
                    
                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();

                    Console.WriteLine($"Bytes lidos da console {totalBytes}");
                }
            }
        }
    }
}
