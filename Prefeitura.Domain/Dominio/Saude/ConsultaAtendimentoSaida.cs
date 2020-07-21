using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class ConsultaAtendimentoSaida : Entidade
    {
        public Guid IdConsultaAtendimento { get; set; }
        public string Observacao { get; set; }


        [ForeignKey("IdConsultaAtendimento")]
        public ConsultaAtendimento ConsultaAtendimento { get; set; }
    }
}
