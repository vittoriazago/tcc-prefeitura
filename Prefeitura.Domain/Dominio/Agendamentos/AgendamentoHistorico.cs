﻿using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        [ForeignKey("IdAgendamento")]
        public Agendamento Agendamento { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}
