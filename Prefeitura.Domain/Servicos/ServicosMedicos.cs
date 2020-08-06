using Microsoft.EntityFrameworkCore;
using Prefeitura.Negocio.Dominio.Blog;
using Prefeitura.Negocio.Dominio.Financeiro;
using Prefeitura.Negocio.Dominio.Saude;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefeitura.Negocio.Servicos
{
    public class ServicosMedicos
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosMedicos(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Buscar medicos com paginacao
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IEnumerable<Medico> medicos)> Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var medicos = _contexto.Medico.AsQueryable();

            return await medicos.Paginacao(numeroPagina, tamanhoPagina);
        }

    }
}
