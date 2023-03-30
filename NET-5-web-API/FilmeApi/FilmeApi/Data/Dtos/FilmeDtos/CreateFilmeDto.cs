using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Data.Dtos.FilmeDtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatorio.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio.")]
        public string Diretor { get; set; }
        [StringLength(50, ErrorMessage = "O genero não pode passar de 50 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 600 minutos")]
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }
    }
}
