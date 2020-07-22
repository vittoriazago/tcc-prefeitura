﻿using Prefeitura.Negocio.Dominio.Enums;
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

        public int IdAgendamento { get; set; }
        public int IdCidade { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DataHoraAgendamento { get; set; }
        public AgendamentoSolicitacaoSituacaoTipo Situacao { get { return ListaHistorico.Single(h => h.Ativo).Situacao; } }

        [ForeignKey("IdAgendamento")]
        public Agendamento Agendamento { get; set; }

        [ForeignKey("IdCidade")]
        public Cidade Cidade  { get; set; }

        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
        public ICollection<AgendamentoSolicitacaoHistorico> ListaHistorico { get; set; }
    }
}
