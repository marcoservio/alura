using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Aula : IComparable
    {
        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;
        }

        public string Titulo { get; set; }
        public int Tempo { get; set; }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return Titulo.CompareTo(that.Titulo);
        }

        public override string ToString()
        {
            return $"[Titulo: {Titulo}, Tempo: {Tempo} minutos]";
        }
    }
}
