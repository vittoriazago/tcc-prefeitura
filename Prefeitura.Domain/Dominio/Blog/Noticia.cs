using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class Noticia : Entidade
    {
        public string Descricao { get; set; }
        public string ConteudoHtml { get; set; }
        public NoticiaSituacaoTipo Situacao { get { return ListaHistorico.Single(h => h.Ativo).Situacao; } }

        public ICollection<Tag> ListaTag { get; set; }
        public ICollection<NoticiaAutor> ListaAutor { get; set; }
        public ICollection<NoticiaHistorico> ListaHistorico { get; set; }
        public ICollection<Visualizacao> ListaVisualizacao { get; set; }
        public ICollection<Comentario> ListaComentario { get; set; }
        public ICollection<NoticiaCidade> ListaCidade { get; set; }
    }
}
