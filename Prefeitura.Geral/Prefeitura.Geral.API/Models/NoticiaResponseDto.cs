using Prefeitura.Geral.Dominio.Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Prefeitura.Geral.Api.Models
{
    public class NoticiaResponseDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string ConteudoHtml { get; set; }
        public DateTime DataCadastro { get; set; }
        public NoticiaSituacaoTipo Situacao { get; set; }
        public List<string> NomesAutores { get; set; }

    }
}
