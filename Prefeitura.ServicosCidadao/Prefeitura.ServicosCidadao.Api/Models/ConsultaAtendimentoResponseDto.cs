using System;

namespace Prefeitura.ServicosCidadao.Api.Models
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
