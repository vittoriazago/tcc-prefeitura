using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefeitura.Models
{
    public class NoticiaResponseDto 
    {
        public string Descricao { get; set; }
        public string ConteudoHtml { get; set; }
        public NoticiaSituacaoTipo Situacao { get; set; }
        public List<string> NomesAutores { get; set; }

    }
}
