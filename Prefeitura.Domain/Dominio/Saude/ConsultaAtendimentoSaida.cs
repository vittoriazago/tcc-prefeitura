using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class ConsultaAtendimentoSaida : Entidade
    {
        public Guid IdConsultaAtendimento { get; set; }
        public string Observacao { get; set; }


        public ConsultaAtendimento ConsultaAtendimento { get; set; }
    }
}
