using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Financeiro
{
    public class Holerite : Entidade
    {
        public int IdFuncionario { get; set; }
        public DateTime DataHoraCadastro { get; set; }
      
        public byte[] Arquivo { get; set; }


        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }

    }
}
