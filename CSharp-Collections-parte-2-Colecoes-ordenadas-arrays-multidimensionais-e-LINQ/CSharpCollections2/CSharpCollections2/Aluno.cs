using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections2
{
    class Aluno
    {
        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }

        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }

        public override string ToString()
        {
            return $"[Aluno: {Nome}, Matricula: {NumeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
                return false;

            return Nome.Equals(outro.Nome);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
