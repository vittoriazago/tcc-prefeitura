using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Geral.Negocio.Dominio.Blog
{
    public class Comentario : Entidade
    {
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public int IdNoticia { get; set; }
        public DateTime DataHora { get; set; }


        [ForeignKey("IdNoticia")]
        public virtual Noticia Noticia { get; set; }

    }
}
