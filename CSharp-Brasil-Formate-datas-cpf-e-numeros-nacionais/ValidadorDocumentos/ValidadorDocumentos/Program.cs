using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "10606435611";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            string cnpj1 = "23886831000108";
            string cnpj2 = "62131537000148";
            string cnpj3 = "12331537000148";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);
            ValidarCNPJ(cnpj3);

            string titulo1 = "582782680167";
            string titulo2 = "228115140108";
            string titulo3 = "228115140100";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);
            ValidarTitulo(titulo3);

            Console.WriteLine(cpf1);
            string v = new CPFFormatter().Format(cpf1);
            Console.WriteLine(v);
            Console.WriteLine(new CPFFormatter().Unformat(v));

            Console.WriteLine(cnpj1);
            Console.WriteLine(new CNPJFormatter().Format(cnpj1));

            Console.WriteLine(titulo1);
            Console.WriteLine(new TituloEleitoralFormatter().Format(titulo1));

            Console.ReadKey();
        }

        public static void ValidarCPF(string cpf)
        {
            if(new CPFValidator().IsValid(cpf))
                Console.WriteLine("CPF válido: " + cpf);
            else
                Console.WriteLine("CPF inválido: " + cpf);
        }

        public static void ValidarCNPJ(string cnpj)
        {
            if(new CNPJValidator().IsValid(cnpj))
                Console.WriteLine("CNPJ válido: " + cnpj);
            else
                Console.WriteLine("CNPJ inválido: " + cnpj);
        }

        public static void ValidarTitulo(string titulo)
        {
            if(new TituloEleitoralValidator().IsValid(titulo))
                Console.WriteLine("Titulo válido: " + titulo);
            else
                Console.WriteLine("Titulo inválido: " + titulo);
        }
    }
}
