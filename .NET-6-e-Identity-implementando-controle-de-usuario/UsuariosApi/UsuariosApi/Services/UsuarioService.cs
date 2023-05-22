using AutoMapper;

using Microsoft.AspNetCore.Identity;

using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class UsuarioService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task Cadastra(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            var resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultado.Succeeded)
                throw new ApplicationException("Falha ao cadastrar usuario");
        }

        public async Task Login(LoginUsuarioDto dto)
        {
             var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if (!resultado.Succeeded)
                throw new ApplicationException("Usuario não autenticado");
        }
    }
}
