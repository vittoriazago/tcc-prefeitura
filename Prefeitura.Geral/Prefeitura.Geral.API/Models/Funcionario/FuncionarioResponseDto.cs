using Prefeitura.Geral.Dominio.Dominio.Enums;

namespace Prefeitura.Geral.Api.Models
{
    public class FuncionarioResponseDto
    {
        public int IdPessoa { get; set; }
        public int IdCidade { get; set; }
        public FuncionarioContratacaoTipo Contratacao { get; set; }
        public FuncionarioSituacaoTipo Situacao { get; set; }
    }
}
