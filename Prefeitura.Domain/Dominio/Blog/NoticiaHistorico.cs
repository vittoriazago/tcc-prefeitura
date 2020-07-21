using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class NoticiaHistorico : Entidade
    {
        public Guid IdNoticia { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public NoticiaSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        [ForeignKey("IdNoticia")]
        public Noticia Noticia { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}
