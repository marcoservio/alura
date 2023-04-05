using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos.GerenteDtos;
using FilmeApi.Models;

using FluentResults;

using Microsoft.EntityFrameworkCore.Metadata.Conventions;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmeApi.Services
{
    public class GerenteService
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public GerenteService(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadGerenteDto Adiciona(CreateGerenteDto gerenteDto)
        {
            var gerente = _mapper.Map<Gerente>(gerenteDto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();

            return _mapper.Map<ReadGerenteDto>(gerente);
        }

        public List<ReadGerenteDto> Recupera()
        {
            var lstGerente = _context.Gerentes.ToList();

            if(lstGerente != null && lstGerente.Count > 0)
                return _mapper.Map<List<ReadGerenteDto>>(lstGerente);

            return null;
        }

        public Result Deleta(int id)
        {
            var gerente = _context.Gerentes.FirstOrDefault(g => g.Id == id);

            if (gerente == null)
                return Result.Fail("Gerente não encontrado");

            _context.Gerentes.Remove(gerente);
            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadGerenteDto RecuperaPorId(int id)
        {
            var gerente = _context.Gerentes.FirstOrDefault(g =>  g.Id == id);

            if (gerente != null)
                return _mapper.Map<ReadGerenteDto>(gerente);

            return null;
        }
    }
}
