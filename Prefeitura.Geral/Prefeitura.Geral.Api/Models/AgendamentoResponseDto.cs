using Prefeitura.Geral.Dominio.Dominio.Enums;
using System;

namespace Prefeitura.Geral.Api.Models
{
    public class AgendamentoResponseDto
    {
        public string Descricao { get; set; }
        public DateTime DataHoraDisponivelInicial { get; set; }
        public DateTime DataHoraDisponivelFinal { get; set; }
        public AgendamentoSituacaoTipo Situacao { get; set; }

    }
}
