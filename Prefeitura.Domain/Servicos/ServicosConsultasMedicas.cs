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
    public class ServicosConsultasMedicas
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosConsultasMedicas(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Buscar consultas medicas com paginacao
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IEnumerable<ConsultaAtendimento> consultas)> 
            Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var consultas = _contexto.ConsultaAtendimento.AsQueryable();

            return await consultas.Paginacao(numeroPagina, tamanhoPagina);
        }

    }
}
