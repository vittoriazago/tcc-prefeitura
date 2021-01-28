using Prefeitura.ServicosCidadao.Dominio.Dominio.Enums;
using System.Collections.Generic;

namespace Prefeitura.ServicosCidadao.Api.Models
{
    public class NoticiaRequestDto
    {
        public string Descricao { get; set; }
        public string ConteudoHtml { get; set; }
        public NoticiaSituacaoTipo NoticiaSituacaoTipo { get; set; }
        public List<int> IdsAutores { get; set; }
        public List<int> IdsCidades { get; set; }

    }
}
