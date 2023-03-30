using AutoMapper;

using FilmeApi.Data.Dtos.FilmeDtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
