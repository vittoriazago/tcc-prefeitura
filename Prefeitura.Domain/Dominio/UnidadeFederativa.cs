using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public class UnidadeFederativa : Entidade
    {
        public string Sigla { get; set; }

        public ICollection<Cidade> ListaCidade { get; set; }

    }
}
