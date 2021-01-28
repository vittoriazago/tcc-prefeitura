using Prefeitura.ServicosCidadao.Dominio.Dominio.Enums;
using System;

namespace Prefeitura.ServicosCidadao.Api.Models
{
    public class AgendamentoSolicitacaoRequestDto
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
