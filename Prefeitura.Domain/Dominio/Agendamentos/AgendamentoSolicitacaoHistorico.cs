using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Agendamentos
{
    public class AgendamentoSolicitacaoHistorico : Entidade
    {
        public Guid IdAgendamento { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public AgendamentoSolicitacaoSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        public AgendamentoSolicitacao Solicitacao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
