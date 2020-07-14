using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
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


        public Funcionario Funcionario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
