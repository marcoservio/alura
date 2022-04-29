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
        static void EscritaBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write(321); // Numero da Agencia
                escritor.Write(3213123); // Numero da Conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Marco Sérvio"); // Titular
            }
        }

        static void LeituraBinararia()
        {
            using(var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using(var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var conta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{conta} {titular} {saldo}");
            }
        }
    }
}
