using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.Geral.Dominio.Dominio.Financeiro
{
    public class Holerite : Entidade
    {
        public int IdFuncionario { get; set; }
        public DateTime DataHoraCadastro { get; set; }

        public byte[] Arquivo { get; set; }


        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

    }
}
