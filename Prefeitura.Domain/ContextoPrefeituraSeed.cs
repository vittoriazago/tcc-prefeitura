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
        }

        public static List<UnidadeFederativa> SeedUFs(this ModelBuilder modelBuilder)
        {
            var ufs = new List<UnidadeFederativa>()
            {
                new UnidadeFederativa(1, "MG" ),
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
