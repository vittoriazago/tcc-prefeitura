using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
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
