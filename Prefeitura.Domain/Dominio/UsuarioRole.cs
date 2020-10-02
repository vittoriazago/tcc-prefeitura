using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Negocio.Dominio
{
    public class UsuarioRole : IdentityUserRole<int>
    {

        public virtual Usuario Usuario { get; set; }
        public virtual Role Role { get; set; }
    }
}
