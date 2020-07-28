using Microsoft.EntityFrameworkCore;
using Prefeitura.Negocio.Dominio.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefeitura.Negocio.Servicos
{
    public class ServicosBlog
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosBlog(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Buscar noticias por paginadas
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IQueryable<Noticia> noticias)> Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var noticias = _contexto.Noticias.AsQueryable();

            return await noticias.Paginacao(numeroPagina, tamanhoPagina);
        }

    }
}
