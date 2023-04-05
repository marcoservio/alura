using AutoMapper;

using FluentResults;

using Microsoft.AspNetCore.Identity;

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

using UsuariosApi.Data;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly EmailService _emailService;

        public CadastroService(IMapper mapper, UserManager<IdentityUser<int>> userManager, EmailService emailService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
        }

        public Result CadastraUsuario(CreateUsuarioDto createDto)
        {
            var usuario = _mapper.Map<Usuario>(createDto);
            var usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
            var resultadoIdentity = _userManager.CreateAsync(usuarioIdentity, createDto.Password);

            if (resultadoIdentity.Result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;
                var encodedCode = HttpUtility.UrlEncode(code);

                _emailService.EnviarEmail(new[] { usuarioIdentity.Email }, 
                    "Link de Ativação", usuarioIdentity.Id, encodedCode);

                return Result.Ok().WithSuccess(code);
            }

            return Result.Fail("Falha ao cadastrar usuario");
        }

        public Result AtivaContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager
                .Users
                .FirstOrDefault(u => u.Id == request.UsuarioId);

            var identityResult = _userManager
                .ConfirmEmailAsync(identityUser, request.CodigoAtivacao).Result;

            if (identityResult.Succeeded)
                return Result.Ok();

            return Result.Fail("Falha ao ativar conta do usuario");
        }
    }
}
