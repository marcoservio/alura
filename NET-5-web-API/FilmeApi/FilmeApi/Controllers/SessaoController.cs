using AutoMapper;
using FilmeApi.Data;
using FilmeApi.Data.Dtos.SessaoDtos;
using FilmeApi.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

using System.Linq;

namespace FilmeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private readonly FilmeContext _context;
        private readonly IMapper _mapper;

        public SessaoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Adiciona([FromBody] CreateSessaoDto sessaoDto)
        {
            var sessao = _mapper.Map<Sessao>(sessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaPorId), new { sessao.Id }, sessao);
        }

        [HttpGet]
        public IEnumerable<Sessao> Recupera()
        {
            return _context.Sessoes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPorId(int id)
        {
            var sessao = _context.Sessoes.FirstOrDefault(s => s.Id == id);

            if (sessao != null)
            {
                var sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return Ok(sessaoDto);
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Deleta(int id)
        {
            var sessao = _context.Sessoes.FirstOrDefault(s => s.Id == id);

            if (sessao == null)
                return NotFound();

            _context.Sessoes.Remove(sessao);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
