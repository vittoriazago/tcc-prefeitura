using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class Hospital : Entidade
    {
        public Guid IdCidade { get; set; }
        public string NomeHospital { get; set; }


        [ForeignKey("IdCidade")]
        public Cidade Cidade { get; set; }
    }
}
