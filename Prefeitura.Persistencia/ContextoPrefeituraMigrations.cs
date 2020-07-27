
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Prefeitura.Negocio;
using Prefeitura.Negocio.Dominio;
using Prefeitura.Negocio.Dominio.Agendamentos;
using Prefeitura.Negocio.Dominio.Blog;
using Prefeitura.Negocio.Dominio.Financeiro;
using Prefeitura.Negocio.Dominio.Saude;
using Prefeitura.Negocio.Dominio.Suporte;

namespace Prefeitura.Persistencia
{
    public class ContextoPrefeituraMigrations : ContextoPrefeitura
    {
        private static readonly IConfiguration Config = Configuration.InitConfiguration();

        public ContextoPrefeituraMigrations() :
            base(new DbContextOptionsBuilder<ContextoPrefeitura>()
                .UseSqlServer(Config.GetConnectionString("DefaultConnection")).Options)
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