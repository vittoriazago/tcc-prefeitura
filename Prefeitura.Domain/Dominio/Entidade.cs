using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }


        public Guid Id { get; set; }
    }
}
