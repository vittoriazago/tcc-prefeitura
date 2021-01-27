using Prefeitura.Geral.Negocio.Dominio.Enums;

namespace Prefeitura.Geral.API.Models
{
    public class FuncionarioRequestDto
    {
        public int IdPessoa { get; set; }
        public int IdCidade { get; set; }
        public FuncionarioContratacaoTipo Contratacao { get; set; }
        public FuncionarioSituacaoTipo Situacao { get; set; }
    }
}
