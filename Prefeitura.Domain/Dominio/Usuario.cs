﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Negocio.Dominio
{
    public class Usuario : IdentityUser
    {
        public int IdPessoa { get; set; }


        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
    }
}
