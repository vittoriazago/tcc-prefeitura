using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio.Blog
{
    public class NoticiaCidade : Entidade
    {
        public int IdNoticia { get; set; }
        public int IdCidade { get; set; }

        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }
        [ForeignKey("IdNoticia")]
        public virtual Noticia Noticia { get; set; }
    }
}
