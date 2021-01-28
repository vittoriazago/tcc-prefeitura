
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Prefeitura.ServicosCidadao.Dominio;
using System;

namespace Prefeitura.ServicosCidadao.Persistencia
{
    public class ContextoPrefeituraMigrations : ContextoPrefeitura
    {
        private static readonly IConfiguration Config = Configuration.InitConfiguration();

        public ContextoPrefeituraMigrations() :
            base(new DbContextOptionsBuilder<ContextoPrefeitura>()
                //.UseSqlServer(Config.GetConnectionString("DefaultConnection")).Options
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options
                )
        {
        }
    }

    public static class Configuration
    {
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            return config;
        }
    }
}