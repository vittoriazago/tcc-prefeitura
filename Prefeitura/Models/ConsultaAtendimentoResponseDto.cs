using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prefeitura.Models
{
    public class ConsultaAtendimentoResponseDto
    {
        public int IdHospital { get; set; }
        public int IdPessoa { get; set; }
        public int IdMedico { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime? DataHoraFinal { get; set; }
    }
}
