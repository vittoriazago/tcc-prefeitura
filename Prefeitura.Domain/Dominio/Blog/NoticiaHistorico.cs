using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
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


        public Noticia Noticia { get; set; }
        public Usuario Usuario { get; set; }
    }
}
