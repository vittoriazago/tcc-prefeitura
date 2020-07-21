using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaCidade : Entidade
    {
        public Guid IdNoticia { get; set; }
        public Guid IdCidade { get; set; }

        [ForeignKey("IdCidade")]
        public Cidade Cidade { get; set; }
        [ForeignKey("IdNoticia")]
        public Noticia Noticia { get; set; }
    }
}
