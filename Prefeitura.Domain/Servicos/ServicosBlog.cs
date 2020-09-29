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
        /// Buscar noticias com paginação
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

        /// <summary>
        /// Nova noticia
        /// </summary>
        /// <param name="noticia"></param>
        /// <returns></returns>
        public async Task<Noticia> AdicionarNoticia(Noticia noticia)
        {
            await _contexto.AddAsync(noticia).ConfigureAwait(false);

            await _contexto.SaveChangesAsync().ConfigureAwait(false);

            return noticia;
        }
    }
}
