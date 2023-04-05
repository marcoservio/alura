using AutoMapper;
using FilmeApi.Data.Dtos.FilmeDtos;
using FilmeApi.Data;
using FilmeApi.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using FilmeApi.Data.Dtos.EnderecoDtos;
using System.Linq;
using FilmeApi.Services;
using FluentResults;

namespace FilmeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly EnderecoService _service;

        public EnderecoController(EnderecoService enderecoService)
        {
            _service = enderecoService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] CreateEnderecoDto enderecoDto)
        {
            ReadEnderecoDto readDto = _service.Adiciona(enderecoDto);

            return CreatedAtAction(nameof(RecuperaPorId), new { readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult Recupera()
        {
            List<ReadEnderecoDto> lstReadDto = _service.Recupera();

            if(lstReadDto != null && lstReadDto.Count > 0)
                return Ok(lstReadDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPorId(int id)
        {
            ReadEnderecoDto readDto = _service.RecuperaPorId(id);

            if(readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Result resultado = _service.Atualiza(id, enderecoDto);

            if(resultado.IsFailed) 
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deleta(int id)
        {
            Result resultado = _service.Deleta(id);

            if(resultado.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
