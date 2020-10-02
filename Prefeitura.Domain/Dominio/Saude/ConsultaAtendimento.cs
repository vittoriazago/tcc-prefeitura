using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class ConsultaAtendimento : Entidade
    {
        public int IdHospital { get; set; }
        public int IdPessoa { get; set; }
        public int IdMedico { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime? DataHoraFinal { get; set; }

        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("IdMedico")]
        public virtual Medico Medico { get; set; }
        [ForeignKey("IdHospital")]
        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<ConsultaAtendimentoSaida> ListaConsultaAtendimentoSaida { get; set; }
    }
}
