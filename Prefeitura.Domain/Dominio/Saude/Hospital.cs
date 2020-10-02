using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class Hospital : Entidade
    {
        public int IdCidade { get; set; }
        public string NomeHospital { get; set; }


        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }
    }
}
