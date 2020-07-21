using Prefeitura.Negocio.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Financeiro
{
    public class Funcionario : Entidade
    {
        public Guid IdPessoa { get; set; }
        public Guid IdPrefeitura { get; set; }
        public FuncionarioContratacaoTipo Contratacao { get; set; }
        public FuncionarioSituacaoTipo Situacao
        {
            get
            {
                return ListaHistorico.Single(h => h.Ativo).Situacao;
            }
        }
        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
        [ForeignKey("IdPrefeitura")]
        public Prefeitura Prefeitura { get; set; }


        public ICollection<FuncionarioHistorico> ListaHistorico { get; set; }
        public ICollection<Holerite> ListaHolerite { get; set; }
        public ICollection<PontoRegistro> ListaPontoRegistro { get; set; }
    }
}
