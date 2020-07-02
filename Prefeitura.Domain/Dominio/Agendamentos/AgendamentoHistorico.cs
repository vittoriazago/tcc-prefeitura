using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Agendamentos
{
    public class AgendamentoHistorico : Entidade
    {
        public Guid IdAgendamento { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public AgendamentoSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        public Agendamento Agendamento { get; set; }
        public Usuario Usuario { get; set; }
    }
}
