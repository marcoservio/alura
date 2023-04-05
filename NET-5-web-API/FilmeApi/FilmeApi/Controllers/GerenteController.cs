using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos.GerenteDtos;
using FilmeApi.Models;
using FilmeApi.Services;

using FluentResults;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

using System.Linq;

namespace FilmeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private readonly GerenteService _service;

        public GerenteController(GerenteService gerenteService)
        {
            _service = gerenteService;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] CreateGerenteDto gerenteDto)
        {
            ReadGerenteDto readDto = _service.Adiciona(gerenteDto);

            return CreatedAtAction(nameof(RecuperaPorId), new { readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult Recupera()
        {
            List<ReadGerenteDto> lstReadDto = _service.Recupera();

            if(lstReadDto != null  && lstReadDto.Count > 0)
                return Ok(lstReadDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPorId(int id)
        {
            ReadGerenteDto readDto = _service.RecuperaPorId(id);

            if(readDto != null)
                return Ok(readDto);

            return NotFound();
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
