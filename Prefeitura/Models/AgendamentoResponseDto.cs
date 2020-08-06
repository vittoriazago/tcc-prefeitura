using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefeitura.Models
{
    public class AgendamentoResponseDto
    {
        public string Descricao { get; set; }
        public DateTime DataHoraDisponivelInicial { get; set; }
        public DateTime DataHoraDisponivelFinal { get; set; }
        public AgendamentoSituacaoTipo Situacao { get; set; }

    }
}
