using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Financeiro
{
    public class FuncionarioHistorico : Entidade
    {
        public int IdFuncionario { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public FuncionarioSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
