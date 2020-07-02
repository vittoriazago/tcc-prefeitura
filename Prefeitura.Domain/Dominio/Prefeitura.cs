using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public class Prefeitura : Entidade
    {
        public Guid IdCidade { get; set; }

        public Cidade Cidade { get; set; }

    }
}
