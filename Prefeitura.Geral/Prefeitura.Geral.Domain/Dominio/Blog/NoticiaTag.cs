using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Geral.Negocio.Dominio.Blog
{
    public class NoticiaTag : Entidade
    {
        public int IdNoticia { get; set; }
        public int IdTag { get; set; }

        [ForeignKey("IdTag")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("IdNoticia")]
        public virtual Noticia Noticia { get; set; }
    }
}
