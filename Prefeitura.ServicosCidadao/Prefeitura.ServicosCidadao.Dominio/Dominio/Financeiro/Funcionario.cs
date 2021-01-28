using Prefeitura.ServicosCidadao.Dominio.Dominio.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio.Financeiro
{
    public class Funcionario : Entidade
    {
        public int IdPessoa { get; set; }
        public int IdCidade { get; set; }
        public FuncionarioContratacaoTipo Contratacao { get; set; }
        public FuncionarioSituacaoTipo Situacao
        {
            get
            {
                return ListaHistorico.Single(h => h.Ativo).Situacao;
            }
        }
        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }


        public virtual ICollection<FuncionarioHistorico> ListaHistorico { get; set; }
        public virtual ICollection<Holerite> ListaHolerite { get; set; }
        public virtual ICollection<PontoRegistro> ListaPontoRegistro { get; set; }
    }
}
