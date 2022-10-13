using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,743633,4354.50,Gustavo,Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWrite()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("312,312312,312.90,Pedro");
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using(var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for(int i = 0; i < 10000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); // Despeja o buffer para o Stream!

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma");
                    Console.ReadLine();
                }
            }
        }
    }
}