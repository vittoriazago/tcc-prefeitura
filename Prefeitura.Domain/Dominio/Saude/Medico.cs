using Prefeitura.Negocio.Dominio.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class Medico : Entidade
    {
        public Guid IdFuncionario { get; set; }
        public string Crm { get; set; }

        public Funcionario Funcionario { get; set; }
    }
}
