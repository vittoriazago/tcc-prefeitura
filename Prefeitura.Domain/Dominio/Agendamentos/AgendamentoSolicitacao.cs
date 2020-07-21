using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Agendamentos
{
    public class AgendamentoSolicitacao : Entidade
    {
        public string Observacao { get; set; }
        public bool Preferencial { get; set; }
        public int Senha { get; set; }

        public Guid IdAgendamento { get; set; }
        public Guid IdPrefeitura { get; set; }
        public Guid IdPessoa { get; set; }
        public DateTime DataHoraAgendamento { get; set; }
        public AgendamentoSolicitacaoSituacaoTipo Situacao { get { return ListaHistorico.Single(h => h.Ativo).Situacao; } }

        [ForeignKey("IdAgendamento")]
        public Agendamento Agendamento { get; set; }

        [ForeignKey("IdPrefeitura")]
        public Prefeitura Prefeitura { get; set; }

        [ForeignKey("IdPessoa")]
        public Prefeitura Pessoa { get; set; }
        public ICollection<AgendamentoSolicitacaoHistorico> ListaHistorico { get; set; }
    }
}
