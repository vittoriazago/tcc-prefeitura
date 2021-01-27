using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Prefeitura.Geral.Negocio.Dominio
{
    public class Role : IdentityRole<int>
    {
        public virtual List<UsuarioRole> UsuarioRoles { get; set; }
    }
}
