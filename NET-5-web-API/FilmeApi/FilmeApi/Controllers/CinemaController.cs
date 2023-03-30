using AutoMapper;
using FilmeApi.Data.Dtos.EnderecoDtos;
using FilmeApi.Data;
using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FilmeApi.Data.Dtos.CinemaDtos;
using System.Linq;

namespace FilmeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public CinemaController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] CreateCinemaDto cinemaDto)
        {
            var cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaPorId), new { cinema.Id }, cinema);
        }

        [HttpGet]
        public IActionResult Recupera([FromQuery] string nomeFilme)
        {
            List<Cinema> cinemas = _context.Cinemas.ToList();

            if (cinemas == null || cinemas.Count == 0)
                return NotFound();

            if (!string.IsNullOrEmpty(nomeFilme))
            {
                var query = from cinema in cinemas
                            where cinema.Sessoes.Any(sessao => sessao.Filme.Titulo == nomeFilme.Trim())
                            select cinema;

                cinemas = query.ToList();
            }

            List<ReadCinemaDto> readDto = _mapper.Map<List<ReadCinemaDto>>(cinemas);

            return Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPorId(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            if (cinema != null)
            {
                var cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            if (cinema == null)
                return NotFound();

            _mapper.Map(cinemaDto, cinema);

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deleta(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            if (cinema == null)
                return NotFound();

            _context.Cinemas.Remove(cinema);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
