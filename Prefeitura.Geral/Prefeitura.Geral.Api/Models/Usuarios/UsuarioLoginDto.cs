using System;

namespace Prefeitura.Geral.Api.Models.Usuarios
{
    public class UsuarioLoginDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}