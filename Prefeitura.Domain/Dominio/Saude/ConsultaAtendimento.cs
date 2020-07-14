using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class ConsultaAtendimento : Entidade
    {
        public Guid IdHospital { get; set; }
        public Guid IdPessoa { get; set; }
        public Guid IdMedico { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime? DataHoraFinal { get; set; }

        public Pessoa Pessoa { get; set; }
        public Medico Medico { get; set; }
        public Hospital Hospital { get; set; }

        public ICollection<ConsultaAtendimentoSaida> ListaConsultaAtendimentoSaida { get; set; }
    }
}
