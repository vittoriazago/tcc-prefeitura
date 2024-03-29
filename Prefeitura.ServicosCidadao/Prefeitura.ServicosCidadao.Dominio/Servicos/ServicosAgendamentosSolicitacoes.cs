﻿using Prefeitura.ServicosCidadao.Dominio.Dominio.Agendamentos;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Prefeitura.ServicosCidadao.Dominio.Servicos
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

        /// <summary>
        /// Solicitar agendamento
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public async Task<AgendamentoSolicitacao> AdicionarAgendamentoSolicitacao(AgendamentoSolicitacao solicitacao)
        {
            await _contexto.AddAsync(solicitacao);
            await _contexto.SaveChangesAsync();

            await _contexto.AddAsync(new AgendamentoSolicitacaoHistorico()
            {
                IdAgendamentoSolicitacao = solicitacao.Id,
                Ativo = true,
                DataHora = DateTime.Now,
                Situacao = solicitacao.ListaHistorico.First().Situacao,
                IdUsuario = solicitacao.ListaHistorico.First().IdUsuario,

            });
            await _contexto.SaveChangesAsync();

            return solicitacao;
        }
    }
}
