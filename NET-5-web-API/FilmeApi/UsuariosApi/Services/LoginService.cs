using FluentResults;

using Microsoft.AspNetCore.Identity;

using System;
using System.Linq;

using UsuariosApi.Data.Requests;

namespace UsuariosApi.Services
{
    public class LoginService
    {
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly TokenService _tokenService;

        public LoginService(SignInManager<IdentityUser<int>> signInManager, TokenService tokenService)
        {
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public Result LogaUsuario(LoginRequest request)
        {
            var resultadoIdentity = _signInManager
                .PasswordSignInAsync(request.Username, request.Password, false, false);

            if (resultadoIdentity.Result.Succeeded)
            {
                var identityUser = _signInManager
                    .UserManager
                    .Users.FirstOrDefault(u => u.NormalizedUserName == request.Username.ToUpper());

                var token = _tokenService.CreateToken(identityUser);

                return Result.Ok().WithSuccess(token.Valor);
            }

            return Result.Fail("Login Falhou");
        }
    }
}
