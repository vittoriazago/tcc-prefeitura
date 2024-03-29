﻿using Microsoft.EntityFrameworkCore;
using Prefeitura.ServicosCidadao.Dominio.Dominio;
using Prefeitura.ServicosCidadao.Dominio.Dominio.Agendamentos;
using System;
using System.Collections.Generic;

namespace Prefeitura.ServicosCidadao.Dominio
{
    public static class ContextoPrefeituraSeed
    {
        public static void SeedInicial(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUFsCidades();
            modelBuilder.SeedAgendamentos();

            const int ADMIN_ID = 1;
            const int ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<Pessoa>().HasData(new Pessoa
            {
                Id = ADMIN_ID,
                Nome = "Admin",
                Documento = "43553936827",
                DataNascimento = DateTime.Today.AddYears(-20)
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = ADMIN_ID,
                UserName = "myemail@myemail.com",
                NormalizedUserName = "MYEMAIL@MYEMAIL.COM",
                Email = "myemail@myemail.com",
                NormalizedEmail = "MYEMAIL@MYEMAIL.COM",
                EmailConfirmed = true,
                IdPessoa = ADMIN_ID,
                DataCadastro = DateTime.Now,
                Ativo = true,
                PasswordHash = "AQABBAEABCcQAABAEBhd37krE/TyMklt3SIf2Q3ITj/dunHYr7O5Z9UB0R1+dpDbcrHWuTBr8Uh5WR+JrQ==",
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA",
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58"
            });
            modelBuilder.Entity<UsuarioRole>().HasData(new UsuarioRole
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }

        public static void SeedUFsCidades(this ModelBuilder modelBuilder)
        {
            var dados = new List<(UnidadeFederativa, Cidade)>()
            {
                (new UnidadeFederativa(1, "MG"), new Cidade(1, "BAURU", 1 )),
                (new UnidadeFederativa(2, "SP"), new Cidade(2, "BELO HORIZONTE", 2 ))
            };

            dados.ForEach(uf =>
            {
                modelBuilder.Entity<UnidadeFederativa>().HasData(uf.Item1);
                modelBuilder.Entity<Cidade>().HasData(uf.Item2);
            });
        }
        public static void SeedAgendamentos(this ModelBuilder modelBuilder)
        {
            var dados = new List<Agendamento>()
            {
                new Agendamento(1, "Solicitar carteira de trabalho", DateTime.Now, DateTime.Now.AddHours(3)),
                new Agendamento(2, "Minha casa minha vida", DateTime.Now, DateTime.Now.AddHours(3))
            };

            dados.ForEach(ag =>
            {
                modelBuilder.Entity<Agendamento>().HasData(ag);
            });
        }
    }
}
