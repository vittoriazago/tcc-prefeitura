using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = int.Newint();
        }


        [Key]
        public int Id { get; set; }
    }
}
