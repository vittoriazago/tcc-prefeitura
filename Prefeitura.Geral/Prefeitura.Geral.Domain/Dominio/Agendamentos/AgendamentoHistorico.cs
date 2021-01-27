using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Agendamentos
{
    public class AgendamentoHistorico : Entidade
    {
        public int IdAgendamento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public AgendamentoSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        [ForeignKey("IdAgendamento")]
        public virtual Agendamento Agendamento { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
