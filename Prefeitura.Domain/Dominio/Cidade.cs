using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public class Cidade : Entidade
    {
        public string Descricao { get; set; }
        public Guid IdUnidadeFederativa { get; set; }
       
        public UnidadeFederativa UnidadeFederativa { get; set; }

    }
}
