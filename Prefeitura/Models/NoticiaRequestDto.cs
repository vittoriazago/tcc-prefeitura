using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefeitura.Models
{
    public class NoticiaRequestDto
    {
        public string Descricao { get; set; }
        public string ConteudoHtml { get; set; }
        public List<int> IdsAutores { get; set; }

    }
}
