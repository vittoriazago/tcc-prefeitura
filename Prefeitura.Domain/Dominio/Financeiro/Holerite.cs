using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Financeiro
{
    public class Holerite : Entidade
    {
        public Guid IdFuncionario { get; set; }
        public DateTime DataHoraCadastro { get; set; }
      
        public byte[] Arquivo { get; set; }


        public Funcionario Funcionario { get; set; }

    }
}
