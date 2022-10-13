using System;
using static System.Console;
using static System.String;
using static System.DateTime;

namespace CSharp6.R04
{
    class Programa
    {
        public void Main()
        {
            WriteLine("4. Using Static");

            Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12))
            {
                Endereco = "Av Marte",
                Telefone = "33333333"
            };
            WriteLine(aluno.Nome);
            WriteLine(aluno.Sobrenome);

            WriteLine(aluno.NomeCompleto);
            WriteLine("Idade: {0}", aluno.GetIdade());
            WriteLine(aluno.DadosPessoais);
        }
    }

    class Aluno
    {
        public string Nome { get; }

        public string Sobrenome { get; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string DadosPessoais => $"{NomeCompleto}, {Endereco}, {Telefone}";

        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public string NomeCompleto => Nome + " " + Sobrenome; 
        
        public int GetIdade() => (int)(((Now - DataNascimento).TotalDays) / 365.242199);

        public Aluno(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Aluno(string nome, string sobrenome, DateTime dataNascimento) : this(nome, sobrenome)
        {
            this.DataNascimento = dataNascimento;
        }

    }
}
