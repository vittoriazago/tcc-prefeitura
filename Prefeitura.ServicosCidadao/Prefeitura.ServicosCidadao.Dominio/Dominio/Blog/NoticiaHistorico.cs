using Prefeitura.ServicosCidadao.Dominio.Dominio.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio.Blog
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
