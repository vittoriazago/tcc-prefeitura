using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio.Suporte
{
    public class SuporteSolicitacao : Entidade
    {
        public int IdCidade { get; set; }
        public int IdPessoa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Solicitacao { get; set; }


        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }

        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }
    }
}
