using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaTag : Entidade
    {
        public int IdNoticia { get; set; }
        public int IdTag { get; set; }

        [ForeignKey("IdTag")]
        public Tag Tag { get; set; }

        [ForeignKey("IdNoticia")]
        public Noticia Noticia { get; set; }
    }
}
