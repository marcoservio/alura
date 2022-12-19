using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Curso
    {
        public Curso(string nome, string instrutor)
        {
            Nome = nome;
            Instrutor = instrutor;
            aulas = new List<Aula>();
        }

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }
        private List<Aula> aulas;
        public IList<Aula> Aulas
        {
            get
            {
                return new ReadOnlyCollection<Aula>(aulas);
            }
        }
        public string Nome { get; set; }
        public string Instrutor { get; set; }
        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var item in aulas)
                //{
                //    total += item.Tempo;
                //}
                //return total;

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public void Adicionar(Aula aula)
        {
            aulas.Add(aula);
        }

        public override string ToString()
        {
            return $"Curso: {Nome}, Tempo: {TempoTotal}, Aulas: {string.Join(", ", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public Aluno BuscarMatriculado(int numeroMatricula)
        {
            dicionarioAlunos.TryGetValue(numeroMatricula, out Aluno aluno);

            return aluno;
        }

        public void SubstituiAluno(Aluno aluno)
        {
            dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
