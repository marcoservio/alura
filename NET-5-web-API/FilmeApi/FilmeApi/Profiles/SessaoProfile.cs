using AutoMapper;

using FilmeApi.Data.Dtos.SessaoDtos;
using FilmeApi.Models;

namespace FilmeApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioInicio, opts => opts
                .MapFrom(dto => dto.HorarioEncerramento.AddMinutes(dto.Filme.Duracao * (-1))));
        }
    }
}
