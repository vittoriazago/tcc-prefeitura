using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaAutor : Entidade
    {
        public Guid IdAutor { get; set; }
        public Guid IdNoticia { get; set; }

        [ForeignKey("IdAutor")]
        public Pessoa Autor { get; set; }

        [ForeignKey("IdNoticia")]
        public Noticia Noticia { get; set; }
    }
}
