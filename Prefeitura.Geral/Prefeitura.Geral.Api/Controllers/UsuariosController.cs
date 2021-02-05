using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Prefeitura.Geral.Api.Models.Usuarios;
using Prefeitura.Geral.Dominio.Dominio;
using Prefeitura.Geral.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _usuarioManager;
        private readonly IMapper _mapper;
        private readonly ServicosPessoas _servicosPessoas;

        public UsuarioController(IConfiguration config,
            SignInManager<Usuario> signInManager,
            UserManager<Usuario> usuarioManager,
            ServicosPessoas servicosPessoas,
            IMapper mapper
            )
        {
            _config = config;
            _signInManager = signInManager;
            _usuarioManager = usuarioManager;
            _servicosPessoas = servicosPessoas;
            _mapper = mapper;
        }

        [HttpPost("")]
        [AllowAnonymous]
        public async Task<ActionResult<UsuarioNovoDto>> PostUsuario(UsuarioNovoDto usuarioNovoDto)
        {
            try
            {
                var pessoa = await _servicosPessoas.AdicionarPessoa(new Pessoa
                {
                    Nome = usuarioNovoDto.Nome,
                    Documento = usuarioNovoDto.Documento,
                    DataNascimento = usuarioNovoDto.DataNascimento
                });

                var usuario = _mapper.Map<Usuario>(usuarioNovoDto);
                usuario.IdPessoa = pessoa.Id;

                var result = await _usuarioManager.CreateAsync(usuario, usuarioNovoDto.Senha);
                if (result.Succeeded)
                {
                    await _usuarioManager.AddToRoleAsync(usuario, usuarioNovoDto.Perfil == 1 ? "sgm" : "comum");
                }

                if (!result.Succeeded)
                    return BadRequest(result.Errors);

                return Created($"~/", new { });;
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro na inserção!");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetUsuario(string email)
        {
            try
            {
                var usuario = await _usuarioManager.FindByEmailAsync(email.ToUpper());
                return Ok(usuario.Id);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao recuperar usuário!");
            }
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UsuarioLoginDto usuarioLoginDto)
        {
            try
            {
                var usuario = await _usuarioManager.FindByEmailAsync(usuarioLoginDto.Email.ToUpper());

                var result = await _signInManager.CheckPasswordSignInAsync(usuario, usuarioLoginDto.Senha, false);

                if (!result.Succeeded)
                    return Unauthorized();

                var appUsuario = await _usuarioManager.Users
                        .FirstOrDefaultAsync(u => u.NormalizedUserName == usuarioLoginDto.Email.ToUpper());
                var pessoa = await _servicosPessoas.BuscarPessoaPorId(usuario.IdPessoa);

                return Ok(new
                {
                    Token = GenerateJwtToken(appUsuario).Result,
                    Usuario = new
                    {
                        Nome = pessoa.Nome
                    }
                });
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro na autenticação!");
            }
        }

        private async Task<string> GenerateJwtToken(Usuario Usuario)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, Usuario.Id.ToString()),
                new Claim(ClaimTypes.Name, Usuario.UserName),
            };
            var roles = await _usuarioManager.GetRolesAsync(Usuario);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.ASCII
                .GetBytes(_config.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(5),
                SigningCredentials = creds
            };

            IdentityModelEventSource.ShowPII = true;

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
