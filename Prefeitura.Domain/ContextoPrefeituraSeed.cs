using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Prefeitura.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefeitura.Negocio
{
    public static class ContextoPrefeituraSeed
    {
        public static void SeedInicial(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUFs();
            modelBuilder.SeedCidades(2);

            const int ADMIN_ID = 1;
            const int ROLE_ID = ADMIN_ID;
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

        public static List<UnidadeFederativa> SeedUFs(this ModelBuilder modelBuilder)
        {
            var ufs = new List<UnidadeFederativa>()
            {
                new UnidadeFederativa(1, "MG"),
                new UnidadeFederativa(2, "SP")
            };

            ufs.ForEach(uf => modelBuilder.Entity<UnidadeFederativa>().HasData(uf));

            return ufs;
        }
        public static List<Cidade> SeedCidades(this ModelBuilder modelBuilder, int idUnidadeFederativa)
        {
            var cidades = new List<Cidade>()
            {
                new Cidade(1, "BAURU", idUnidadeFederativa ),
                new Cidade(2, "BAURU", idUnidadeFederativa ),
            };

            cidades.ForEach(c => modelBuilder.Entity<Cidade>().HasData(c));
            return cidades;
        }
    }
}
