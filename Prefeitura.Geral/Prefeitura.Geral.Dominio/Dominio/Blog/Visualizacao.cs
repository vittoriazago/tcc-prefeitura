using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Geral.Dominio.Dominio.Blog
{
    public class Visualizacao : Entidade
    {
        public int IdNoticia { get; set; }
        public DateTime DataHora { get; set; }


        [ForeignKey("IdNoticia")]
        public virtual Noticia Noticia { get; set; }
    }
}
