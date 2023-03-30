using FilmeApi.Models;

using System.Collections.Generic;

namespace FilmeApi.Data.Dtos.GerenteDtos
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public object Cinemas { get; set; } 
    }
}
