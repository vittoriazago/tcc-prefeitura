using Microsoft.EntityFrameworkCore;
using Prefeitura.Negocio.Dominio.Agendamentos;
using Prefeitura.Negocio.Dominio.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefeitura.Negocio.Servicos
{
    public class ServicosAgendamentosSolicitacoes
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosAgendamentosSolicitacoes(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Buscar solicitações de agendamentos com paginação
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IQueryable<AgendamentoSolicitacao> solicitacoes)> 
            Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var solicitacaos = _contexto.AgendamentoSolicitacao.AsQueryable();

            return await solicitacaos.Paginacao(numeroPagina, tamanhoPagina);
        }

    }
}
