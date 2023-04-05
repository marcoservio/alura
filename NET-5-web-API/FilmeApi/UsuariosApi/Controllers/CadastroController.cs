using FluentResults;

using Microsoft.AspNetCore.Mvc;

using UsuariosApi.Data.Dtos;
using UsuariosApi.Data.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private readonly CadastroService _service;

        public CadastroController(CadastroService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _service.CadastraUsuario(createDto);

            if (resultado.IsFailed)
                return StatusCode(500);

            return Ok(resultado.Successes);
        }

        [HttpGet("/ativa")]
        public IActionResult AtivaContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result resultado = _service.AtivaContaUsuario(request);

            if(resultado.IsFailed)
                return StatusCode(500);

            return Ok(resultado.Successes);
        }
    }
}
