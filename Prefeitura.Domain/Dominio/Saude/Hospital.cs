using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Saude
{
    public class Hospital : Entidade
    {
        public Hospital()
        {
        }
        public Hospital(int idHospital, int idCidade, string nomeHospital)
        {
            Id = idHospital;
            IdCidade = idCidade;
            NomeHospital = nomeHospital;
        }

        public int IdCidade { get; set; }
        public string NomeHospital { get; set; }


        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }
    }
}
