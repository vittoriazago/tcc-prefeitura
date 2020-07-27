using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Negocio.Dominio
{
    public class Usuario : IdentityUser<int>
    {
        public int IdPessoa { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public List<UsuarioRole> UsuarioRoles { get; set; }

        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }

    }
}
