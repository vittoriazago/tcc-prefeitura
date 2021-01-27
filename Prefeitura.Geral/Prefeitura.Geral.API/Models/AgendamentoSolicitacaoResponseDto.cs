﻿using Prefeitura.Geral.Negocio.Dominio.Enums;
using System;

namespace Prefeitura.Geral.API.Models
{
    public class AgendamentoSolicitacaoResponseDto
    {
        public string Observacao { get; set; }
        public bool Preferencial { get; set; }
        public int Senha { get; set; }

        public int IdAgendamento { get; set; }
        public int IdCidade { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataHoraAgendamento { get; set; }
        public AgendamentoSolicitacaoSituacaoTipo Situacao { get; set; }

    }
}
