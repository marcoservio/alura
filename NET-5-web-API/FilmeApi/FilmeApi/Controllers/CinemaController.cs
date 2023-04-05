using AutoMapper;
using FilmeApi.Data.Dtos.EnderecoDtos;
using FilmeApi.Data;
using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FilmeApi.Data.Dtos.CinemaDtos;
using System.Linq;
using FilmeApi.Services;
using FluentResults;

namespace FilmeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly CinemaService _service;

        public CinemaController(CinemaService chemaService)
        {
            _service = chemaService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] CreateCinemaDto cinemaDto)
        {
            ReadCinemaDto readDto = _service.Adiciona(cinemaDto);

            return CreatedAtAction(nameof(RecuperaPorId), new { readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult Recupera([FromQuery] string nomeFilme)
        {
            List<ReadCinemaDto> lstReadDto = _service.Recupera(nomeFilme);

            if(lstReadDto != null && lstReadDto.Count > 0)
                return Ok(lstReadDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPorId(int id)
        {
            ReadCinemaDto readDto = _service.RecuperaPorId(id);

            if(readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Result resultado = _service.Atualiza(id, cinemaDto);

            if (resultado.IsFailed)
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
