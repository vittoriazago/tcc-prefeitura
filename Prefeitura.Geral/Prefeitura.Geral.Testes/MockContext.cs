using Microsoft.EntityFrameworkCore;
using Prefeitura.Geral.Negocio;
using Prefeitura.Geral.Negocio.Dominio.Agendamentos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Testes
{
    /// <summary>
    /// Mock do contexto
    /// </summary>
    public static class MockContext
    {
        /// <summary>
        /// Retorna o contexto mock
        /// </summary>
        /// <returns></returns>
        public static async Task<ContextoPrefeitura> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ContextoPrefeitura>()
                         .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                         .Options;
            var databaseContext = new ContextoPrefeitura(options);

            await PopularAgendamentos(databaseContext);

            return databaseContext;
        }

        private static async Task PopularAgendamentos(ContextoPrefeitura databaseContext)
        {
            var listaFuncionalidade = new List<AgendamentoSolicitacao>
            {
                new AgendamentoSolicitacao
                {
                }
            };

            await databaseContext.AgendamentoSolicitacao.AddRangeAsync(listaFuncionalidade).ConfigureAwait(false);
            await databaseContext.SaveChangesAsync();
        }

    }
}
