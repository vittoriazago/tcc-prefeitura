using Prefeitura.Geral.Dominio.Dominio.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Geral.Dominio.Dominio.Agendamentos
{
    public class AgendamentoSolicitacaoHistorico : Entidade
    {
        public int IdAgendamentoSolicitacao { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public AgendamentoSolicitacaoSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        [ForeignKey("IdAgendamentoSolicitacao")]
        public virtual AgendamentoSolicitacao Solicitacao { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
