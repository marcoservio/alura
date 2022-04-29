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
        static void Main(string[] args)
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado");

            var bytesArquivo = File.ReadAllBytes("Contas.txt");

            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            Console.ReadLine();

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach(var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();

            Console.Write("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine(nome);

            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação finalizada...");

            Console.ReadLine();
        }
    }
}
