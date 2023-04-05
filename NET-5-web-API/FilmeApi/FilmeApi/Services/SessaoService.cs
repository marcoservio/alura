using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos.SessaoDtos;
using FilmeApi.Models;

using FluentResults;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmeApi.Services
{
    public class SessaoService
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public SessaoService(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadSessaoDto Adiciona(CreateSessaoDto sessaoDto)
        {
            var sessao = _mapper.Map<Sessao>(sessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();

            return _mapper.Map<ReadSessaoDto>(sessao);
        }

        public List<ReadSessaoDto> Recupera()
        {
            var lstSessao = _context.Sessoes.ToList();

            if (lstSessao != null && lstSessao.Count > 0)
                return _mapper.Map<List<ReadSessaoDto>>(lstSessao);

            return null;
        }

        public ReadSessaoDto RecuperaPorId(int id)
        {
            var sessao = _context.Sessoes.FirstOrDefault(s => s.Id == id);

            if (sessao != null)
                return _mapper.Map<ReadSessaoDto>(sessao);

            return null;
        }

        public Result Deleta(int id)
        {
            var sessao = _context.Sessoes.FirstOrDefault(s => s.Id == id);

            if (sessao == null)
                return Result.Fail("Sessão não encontrada");

            _context.Sessoes.Remove(sessao);
            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
