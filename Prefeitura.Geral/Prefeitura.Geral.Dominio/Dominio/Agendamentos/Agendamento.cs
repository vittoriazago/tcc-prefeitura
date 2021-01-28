using Prefeitura.Geral.Dominio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prefeitura.Geral.Dominio.Dominio.Agendamentos
{
    public class Agendamento : Entidade
    {
        public Agendamento()
        {
        }
        public Agendamento(int id,
            string descricao, DateTime dataHoraDisponivelInicial, DateTime dataHoraDisponivelFinal)
        {
            Id = id;
            Descricao = descricao;
            DataHoraDisponivelInicial = dataHoraDisponivelInicial;
            DataHoraDisponivelFinal = dataHoraDisponivelFinal;
        }

        public string Descricao { get; set; }
        public DateTime DataHoraDisponivelInicial { get; set; }
        public DateTime DataHoraDisponivelFinal { get; set; }
        public AgendamentoSituacaoTipo Situacao { get { return ListaHistorico.Single(h => h.Ativo).Situacao; } }

        public virtual ICollection<AgendamentoHistorico> ListaHistorico { get; set; }
    }
}
