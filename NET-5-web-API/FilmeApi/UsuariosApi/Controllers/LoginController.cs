using FluentResults;

using Microsoft.AspNetCore.Mvc;

using UsuariosApi.Data.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _service;

        public LoginController(LoginService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult LoginUsuario(LoginRequest request)
        {
            Result resultado = _service.LogaUsuario(request);

            if(resultado.IsFailed)
                return Unauthorized(resultado.Errors);

            return Ok(resultado.Successes);
        }

        [HttpPost("/solicita-reset")]
        public IActionResult SolicitaResetSenhaUsuario(SolicitaResetRequest request)
        {
            Result resultado = _service.SolicitaResetSenhaUsuario(request);

            if( resultado.IsFailed)
                return Unauthorized(resultado.Errors);

            return Ok(resultado.Successes);
        }

        [HttpPost("/efetua-reset")]
        public IActionResult ResetaSenhaUsuario(EfetuaResetRequest request)
        {
            Result resultado = _service.ResetaSenhaUsuario(request);

            if (resultado.IsFailed)
                return Unauthorized(resultado.Errors);

            return Ok(resultado.Successes);
        }
    }
}
