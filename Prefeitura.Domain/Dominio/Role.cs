using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Negocio.Dominio
{
    public class Role : IdentityRole<int>
    {
        public List<UsuarioRole> UsuarioRoles { get; set; }
    }
}
