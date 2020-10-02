using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaHistorico : Entidade
    {
        public int IdNoticia { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public NoticiaSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        [ForeignKey("IdNoticia")]
        public virtual Noticia Noticia { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
