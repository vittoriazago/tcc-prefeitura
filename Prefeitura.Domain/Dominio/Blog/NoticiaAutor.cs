using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaAutor : Entidade
    {
        public Guid IdAutor { get; set; }
        public Guid IdNoticia { get; set; }

        public Pessoa Autor { get; set; }
        public Noticia Noticia { get; set; }
    }
}
