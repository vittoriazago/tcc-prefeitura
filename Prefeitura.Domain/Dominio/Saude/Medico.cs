using Prefeitura.Negocio.Dominio.Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class Medico : Entidade
    {
        public int IdFuncionario { get; set; }
        public string Crm { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
    }
}
