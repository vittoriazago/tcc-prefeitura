﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class ConsultaAtendimentoSaida : Entidade
    {
        public int IdConsultaAtendimento { get; set; }
        public string Observacao { get; set; }


        [ForeignKey("IdConsultaAtendimento")]
        public virtual ConsultaAtendimento ConsultaAtendimento { get; set; }
    }
}
