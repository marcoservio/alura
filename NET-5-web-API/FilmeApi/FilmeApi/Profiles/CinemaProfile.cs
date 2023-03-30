using AutoMapper;

using FilmeApi.Data.Dtos.CinemaDtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
