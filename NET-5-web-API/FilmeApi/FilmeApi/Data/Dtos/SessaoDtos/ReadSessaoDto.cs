using FilmeApi.Models;

using System;

namespace FilmeApi.Data.Dtos.SessaoDtos
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public Cinema Cinema { get; set; }
        public Filme Filme { get; set; }
        public DateTime HorarioEncerramento { get; set; }
        public DateTime HorarioInicio { get; set; }
    }
}
