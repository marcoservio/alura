using AutoMapper;

using FilmeAPI.Data.Dtos;
using FilmeAPI.Models;

namespace FilmeAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>().ForMember(dto => dto.Endereco, 
                opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<Cinema, ReadCinemaDto>().ForMember(dto => dto.Sessoes,
                opt => opt.MapFrom(cinema => cinema.Sessoes));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
