using AutoMapper;

using FilmeApi.Data;
using FilmeApi.Data.Dtos.FilmeDtos;
using FilmeApi.Models;

using FluentResults;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmeApi.Services
{
    public class FilmeService
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public FilmeService(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadFilmeDto Adiciona(CreateFilmeDto filmeDto)
        {
            var filme = _mapper.Map<Filme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();

            return _mapper.Map<ReadFilmeDto>(filme);
        }

        public List<ReadFilmeDto> Recupera(int? classificacaoEtaria)
        {
            var lstFilmes = new List<Filme>();

            if (classificacaoEtaria == null)
                lstFilmes = _context.Filmes.ToList();
            else
                lstFilmes = _context.Filmes.Where(f => f.ClassificacaoEtaria <= classificacaoEtaria).ToList();

            if (lstFilmes != null)
                return _mapper.Map<List<ReadFilmeDto>>(lstFilmes);

            return null;
        }

        public ReadFilmeDto RecuperaPorId(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filmes => filmes.Id == id);

            if (filme != null)
                return _mapper.Map<ReadFilmeDto>(filme);

            return null;
        }

        public Result Atualiza(int id, UpdateFilmeDto filmeDto)
        {
            var filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
                return Result.Fail("Filme não encontrado");

            _mapper.Map(filmeDto, filme);
            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Deleta(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

            if (filme == null)
                return Result.Fail("Filme não encontrado");

            _context.Filmes.Remove(filme);
            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
