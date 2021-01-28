﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio
{
    public class Role : IdentityRole<int>
    {
        public virtual List<UsuarioRole> UsuarioRoles { get; set; }
    }
}
