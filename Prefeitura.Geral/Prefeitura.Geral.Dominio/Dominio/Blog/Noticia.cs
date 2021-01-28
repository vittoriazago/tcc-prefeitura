using Prefeitura.Geral.Dominio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prefeitura.Geral.Dominio.Dominio.Blog
{
    public class Noticia : Entidade
    {
        public string Descricao { get; set; }
        public string ConteudoHtml { get; set; }
        public DateTime DataCadastro { get; set; }
        public NoticiaSituacaoTipo Situacao { get { return ListaHistorico.Single(h => h.Ativo).Situacao; } }

        public virtual ICollection<NoticiaTag> ListaNoticiaTag { get; set; }
        public virtual ICollection<NoticiaAutor> ListaAutor { get; set; }
        public virtual ICollection<NoticiaHistorico> ListaHistorico { get; set; }
        public virtual ICollection<Visualizacao> ListaVisualizacao { get; set; }
        public virtual ICollection<Comentario> ListaComentario { get; set; }
        public virtual ICollection<NoticiaCidade> ListaCidade { get; set; }
    }
}
