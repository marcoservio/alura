using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos.EnderecoDtos;
using FilmeApi.Models;

using FluentResults;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmeApi.Services
{
    public class EnderecoService
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public EnderecoService(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadEnderecoDto Adiciona(CreateEnderecoDto enderecoDto)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();

            return _mapper.Map<ReadEnderecoDto>(endereco);
        }

        public List<ReadEnderecoDto> Recupera()
        {
            var lstEndereco = _context.Enderecos.ToList();

            if (lstEndereco == null || lstEndereco.Count == 0)
                return null;

            return _mapper.Map<List<ReadEnderecoDto>>(lstEndereco);
        }

        public ReadEnderecoDto RecuperaPorId(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

            if (endereco != null)
            {
                return _mapper.Map<ReadEnderecoDto>(endereco);
            }

            return null;
        }

        public Result Atualiza(int id, UpdateEnderecoDto enderecoDto)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

            if (endereco == null)
                return Result.Fail("Endereço não encontrado");

            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();

            return Result.Ok();
        }

        public Result Deleta(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

            if (endereco == null)
                return Result.Fail("Endereço não encontrado");

            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();

            return Result.Ok();
        }
    }
}
