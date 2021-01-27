﻿using Prefeitura.Geral.Negocio.Dominio.Agendamentos;
using System.Linq;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Negocio.Servicos
{
    public class ServicosAgendamentos
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosAgendamentos(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Buscar agendamentos com paginação
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IQueryable<Agendamento> agendamentos)> Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var agendamentos = _contexto.Agendamentos.AsQueryable();

            return await agendamentos.Paginacao(numeroPagina, tamanhoPagina);
        }

    }
}
