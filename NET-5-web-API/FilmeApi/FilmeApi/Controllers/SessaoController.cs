using AutoMapper;

using FilmeApi.Data;
using FilmeApi.Data.Dtos.SessaoDtos;
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
    public class SessaoController : ControllerBase
    {
        private readonly SessaoService _service;

        public SessaoController(SessaoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] CreateSessaoDto sessaoDto)
        {
            ReadSessaoDto readDto = _service.Adiciona(sessaoDto);

            return CreatedAtAction(nameof(RecuperaPorId), new { readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult Recupera()
        {
            List<ReadSessaoDto> lstReadDto = _service.Recupera();

            if (lstReadDto != null && lstReadDto.Count > 0)
                return Ok(lstReadDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPorId(int id)
        {
            ReadSessaoDto readDto = _service.RecuperaPorId(id);

            if (readDto != null)
                return Ok(readDto.Id);

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Deleta(int id)
        {
            Result resultado = _service.Deleta(id);

            if (resultado.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
