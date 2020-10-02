using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Agendamentos
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
