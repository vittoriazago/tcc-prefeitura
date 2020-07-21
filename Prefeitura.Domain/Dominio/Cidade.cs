using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public class Cidade : Entidade
    {
        public string Descricao { get; set; }
        public Guid IdUnidadeFederativa { get; set; }

        [ForeignKey("IdUnidadeFederativa")]
        public UnidadeFederativa UnidadeFederativa { get; set; }

    }
}
