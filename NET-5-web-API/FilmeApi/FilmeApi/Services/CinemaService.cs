using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos.CinemaDtos;
using FilmeApi.Models;

using FluentResults;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmeApi.Services
{
    public class CinemaService
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public CinemaService(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadCinemaDto Adiciona(CreateCinemaDto cinemaDto)
        {
            var cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();

            return _mapper.Map<ReadCinemaDto>(cinema);
        }

        public List<ReadCinemaDto> Recupera(string nomeFilme)
        {
            var lstCinema = _context.Cinemas.ToList();

            if (lstCinema == null || lstCinema.Count == 0)
                return null;

            if (!string.IsNullOrEmpty(nomeFilme))
            {
                var query = from cinema in lstCinema
                            where cinema.Sessoes.Any(sessao => sessao.Filme.Titulo == nomeFilme.Trim())
                            select cinema;

                lstCinema = query.ToList();
            }

            return _mapper.Map<List<ReadCinemaDto>>(lstCinema);
        }

        public ReadCinemaDto RecuperaPorId(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            if (cinema != null)
            {
                var cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return cinemaDto;
            }

            return null;
        }

        public Result Atualiza(int id, UpdateCinemaDto cinemaDto)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            if (cinema == null)
                return Result.Fail("Cinema não encontrado");

            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Deleta(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            if (cinema == null)
                return Result.Fail("Cinema não encontrado");

            _context.Cinemas.Remove(cinema);
            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
