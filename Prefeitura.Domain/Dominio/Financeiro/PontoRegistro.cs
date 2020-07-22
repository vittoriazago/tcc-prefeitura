using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Financeiro
{
    public class PontoRegistro : Entidade
    {
        public int IdFuncionario { get; set; }
        public DateTime DataHoraCadastro { get; set; }


        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }

    }
}
