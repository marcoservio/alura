using System;
using static System.Console;
using static System.String;
using static System.DateTime;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;

namespace CSharp6.R09
{
    class Programa
    {
        public async void Main()
        {
            WriteLine("9. Await em Blocos Catch e Finally");

            StreamWriter logAplicacao = new StreamWriter("logAplicacao.txt");

            try
            {
                await logAplicacao.WriteLineAsync("Aplicação está iniciando...");

                Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12))
                {
                    Endereco = "Av Marte",
                    Telefone = "33333333"
                };
                await logAplicacao.WriteLineAsync("Aluno Marty Macfly foi criado...");
                WriteLine(aluno.Nome);
                WriteLine(aluno.Sobrenome);

                WriteLine(aluno.NomeCompleto);
                WriteLine("Idade: {0}", aluno.GetIdade());
                WriteLine(aluno.DadosPessoais);

                aluno.AdicionarAvaliacao(new Avaliacao(1, "Geografia", 8));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "Matematica", 7));
                aluno.AdicionarAvaliacao(new Avaliacao(1, "Historia", 9));
                ImprimirMelhorNota(aluno);

                Aluno aluno2 = new Aluno("Bart", "Simpson");
                await logAplicacao.WriteLineAsync("Aluno Bart Simpson foi criado...");
                ImprimirMelhorNota(aluno2);

                aluno.PropertyChanged += Aluno_PropertyChanged;

                aluno.Endereco = "Rua Vegueiro 3185";
                aluno.Telefone = "555-1234";

                Aluno aluno3 = new Aluno("Charlie", "");
                await logAplicacao.WriteLineAsync("Aluno Charlie Brown foi criado...");
            }
            catch(ArgumentException ex) when(ex.Message.Contains("não informado"))
            {
                string msg = $"Parâmetro {ex.ParamName} não foi informado!";
                await logAplicacao.WriteLineAsync(msg);
                WriteLine(msg);
            }
            catch(ArgumentException)
            {
                string msg = "Paramatro com problema!";
                await logAplicacao.WriteLineAsync(msg);
                WriteLine(msg);
            }
            catch(Exception ex)
            {
                await logAplicacao.WriteLineAsync(ex.ToString());
                WriteLine(ex.ToString());
            }
            finally
            {
                await logAplicacao.WriteLineAsync("Aplicação Terminou");
                logAplicacao.Dispose();
            }
        }

        private void Aluno_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            WriteLine($"Propriedade {e.PropertyName} foi alterada!");
        }

        private static void ImprimirMelhorNota(Aluno aluno)
        {
            WriteLine("Melhor nota: {0}", aluno?.MelhorAvaliacao?.Nota);
        }
    }

    class Aluno : INotifyPropertyChanged
    {
        public string Nome { get; }

        public string Sobrenome { get; }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set
            {
                if(endereco != value)
                {
                    endereco = value;
                    OnPropertyChanched();
                    OnPropertyChanched(nameof(DadosPessoais));
                }
            }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set
            {
                if(telefone != value)
                {
                    telefone = value;
                    OnPropertyChanched();
                    OnPropertyChanched(nameof(DadosPessoais));
                }
            }
        }

        private void OnPropertyChanched([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string DadosPessoais => $"{NomeCompleto}, {Endereco}, {Telefone}";

        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public string NomeCompleto => Nome + " " + Sobrenome;

        public int GetIdade() => (int) (((Now - DataNascimento).TotalDays) / 365.242199);

        public Aluno(string nome, string sobrenome)
        {
            VerificarParametroPreenchido(nome, nameof(nome));
            VerificarParametroPreenchido(sobrenome, nameof(sobrenome));

            Nome = nome;
            Sobrenome = sobrenome;
        }

        private static void VerificarParametroPreenchido(string valorParametro, string nomeParametro)
        {
            if(IsNullOrEmpty(valorParametro))
                throw new ArgumentException("Parâmetro não informado", nomeParametro);
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento) : this(nome, sobrenome)
        {
            this.DataNascimento = dataNascimento;
        }

        private IList<Avaliacao> avaliacoes = new List<Avaliacao>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IReadOnlyCollection<Avaliacao> Avaliacoes => new ReadOnlyCollection<Avaliacao>(avaliacoes);

        public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacoes.Add(avaliacao);
        }

        public Avaliacao MelhorAvaliacao => avaliacoes.OrderBy(a => a.Nota).LastOrDefault();
    }

    class Avaliacao
    {
        public Avaliacao(int bimestre, string materia, double nota)
        {
            Bimestre = bimestre;
            Materia = materia;
            Nota = nota;
        }

        public int Bimestre { get; }
        public string Materia { get; }
        public double Nota { get; }
    }
}
