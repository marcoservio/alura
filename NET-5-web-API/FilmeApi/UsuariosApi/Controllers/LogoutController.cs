using FluentResults;

using Microsoft.AspNetCore.Mvc;

using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogoutController : ControllerBase
    {
        private readonly LogoutService _service;

        public LogoutController(LogoutService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult DeslogaUsuario()
        {
            Result resultdo = _service.DeslogaUsuario();

            if (resultdo.IsFailed)
                return Unauthorized(resultdo.Errors);

            return Ok(resultdo.Successes);
        }
    }
}
