using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaCidade : Entidade
    {
        public Guid IdNoticia { get; set; }
        public Guid IdCidade { get; set; }

        public Cidade Cidade { get; set; }
        public Noticia Noticia { get; set; }
    }
}
