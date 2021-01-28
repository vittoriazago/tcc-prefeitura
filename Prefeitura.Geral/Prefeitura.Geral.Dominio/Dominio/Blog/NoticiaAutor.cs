using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Geral.Dominio.Dominio.Blog
{
    public class NoticiaAutor : Entidade
    {
        public int IdAutor { get; set; }
        public int IdNoticia { get; set; }

        [ForeignKey("IdAutor")]
        public virtual Pessoa Autor { get; set; }

        [ForeignKey("IdNoticia")]
        public virtual Noticia Noticia { get; set; }
    }
}
