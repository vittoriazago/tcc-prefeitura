using System;

namespace Prefeitura.Geral.Api.Models.Usuarios
{
    public class UsuarioNovoDto
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        /// <summary>
        /// Perfil de usuario. 1 - Funcionario. 2 - Municipe
        /// </summary>
        public int Perfil { get; set; }

        public DateTime? DataNascimento { get; set; }
    }
}