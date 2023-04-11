using FilmeApi.Data.Dtos.FilmeDtos;
using FilmeApi.Services;

using FluentResults;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace FilmeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly FilmeService _service;

        public FilmeController(FilmeService filmeService)
        {
            _service = filmeService;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            ReadFilmeDto readDto = _service.Adiciona(filmeDto);

            return CreatedAtAction(nameof(RecuperaFilmePorId), new { readDto.Id }, readDto);
        }

        [HttpGet]
        [Authorize(Roles = "admin, regular", Policy = "IdadeMinima")]
        public IActionResult RecuperaFilmes([FromQuery] int? classificacaoEtaria = null)
        {
            List<ReadFilmeDto> lstReadDto = _service.Recupera(classificacaoEtaria);

            if(lstReadDto != null && lstReadDto.Count > 0)
                return Ok(lstReadDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            ReadFilmeDto readDto = _service.RecuperaPorId(id);

            if(readDto != null) 
                return Ok(readDto);

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Result resultado = _service.Atualiza(id, filmeDto);

            if (resultado.IsFailed)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Result resultado = _service.Deleta(id);

            if (resultado.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
