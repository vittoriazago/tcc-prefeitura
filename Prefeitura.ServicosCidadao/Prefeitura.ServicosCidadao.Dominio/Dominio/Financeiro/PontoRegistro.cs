using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio.Financeiro
{
    public class PontoRegistro : Entidade
    {
        public int IdFuncionario { get; set; }
        public DateTime DataHoraCadastro { get; set; }


        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

    }
}
