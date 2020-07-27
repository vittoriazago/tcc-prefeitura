using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Negocio.Dominio
{
    public class UsuarioRole : IdentityUserRole<int>
    {
        public int IdPessoa { get; set; }


        public Usuario Usuario { get; set; }
        public Role Role { get; set; }
    }
}
