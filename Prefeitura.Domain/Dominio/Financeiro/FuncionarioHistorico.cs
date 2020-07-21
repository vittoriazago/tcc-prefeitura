using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Financeiro
{
    public class FuncionarioHistorico : Entidade
    {
        public Guid IdFuncionario { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public FuncionarioSituacaoTipo Situacao { get; set; }
        public bool Ativo { get; set; }


        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}
