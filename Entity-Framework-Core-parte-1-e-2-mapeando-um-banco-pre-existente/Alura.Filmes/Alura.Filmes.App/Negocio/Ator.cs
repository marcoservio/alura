using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Ator
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public IList<FilmeAtor> Filmografia { get; set; }

        public Ator()
        {
            Filmografia = new List<FilmeAtor>();
        }

        public override string ToString()
        {
            return $"Ator({Id}): {PrimeiroNome} {UltimoNome}";
        }
    }
}
