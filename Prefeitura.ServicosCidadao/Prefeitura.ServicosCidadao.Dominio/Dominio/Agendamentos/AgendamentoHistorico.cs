using Prefeitura.ServicosCidadao.Dominio.Dominio.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio.Agendamentos
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
