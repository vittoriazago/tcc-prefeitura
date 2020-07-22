using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaAutor : Entidade
    {
        public int IdAutor { get; set; }
        public int IdNoticia { get; set; }

        [ForeignKey("IdAutor")]
        public Pessoa Autor { get; set; }

        [ForeignKey("IdNoticia")]
        public Noticia Noticia { get; set; }
    }
}
