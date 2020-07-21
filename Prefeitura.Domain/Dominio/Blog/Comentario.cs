using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class Comentario : Entidade
    {
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public Guid IdNoticia { get; set; }
        public DateTime DataHora { get; set; }


        [ForeignKey("IdNoticia")]
        public Noticia Noticia { get; set; }

    }
}
