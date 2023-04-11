﻿using FluentResults;

using Microsoft.AspNetCore.Identity;

using System;
using System.Linq;

using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class LoginService
    {
        private readonly SignInManager<CustomIdentityUser> _signInManager;
        private readonly TokenService _tokenService;

        public LoginService(SignInManager<CustomIdentityUser> signInManager, TokenService tokenService)
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

                var token = _tokenService
                    .CreateToken(identityUser, _signInManager
                        .UserManager.GetRolesAsync(identityUser).Result.FirstOrDefault());

                return Result.Ok().WithSuccess(token.Valor);
            }

            return Result.Fail("Login Falhou");
        }

        public Result SolicitaResetSenhaUsuario(SolicitaResetRequest request)
        {
            CustomIdentityUser identityUser = RecuperaUsuarioPorEmail(request.Email);

            if (identityUser != null)
            {
                string codigoRecuperacao = _signInManager
                    .UserManager.GeneratePasswordResetTokenAsync(identityUser).Result;

                return Result.Ok().WithSuccess(codigoRecuperacao);
            }

            return Result.Fail("Falha ao solicitar redefinição");
        }

        public Result ResetaSenhaUsuario(EfetuaResetRequest request)
        {
            CustomIdentityUser identityUser = RecuperaUsuarioPorEmail(request.Email);

            IdentityResult resultadoIdentity = _signInManager
                .UserManager.ResetPasswordAsync(identityUser, request.Token, request.Password).Result;

            if (resultadoIdentity.Succeeded)
                return Result.Ok().WithSuccess("Senha redefinida com sucesso");

            return Result.Fail("Houve um erro no operação");
        }

        private CustomIdentityUser RecuperaUsuarioPorEmail(string email)
        {
            return _signInManager
                            .UserManager
                            .Users
                            .FirstOrDefault(u => u.NormalizedEmail == email.ToUpper());
        }
    }
}
