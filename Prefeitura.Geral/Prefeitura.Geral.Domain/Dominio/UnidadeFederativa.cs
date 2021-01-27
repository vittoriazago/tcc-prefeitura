﻿using System.Collections.Generic;

namespace Prefeitura.Geral.Negocio.Dominio
{
    public class UnidadeFederativa : Entidade
    {
        public UnidadeFederativa()
        {
        }

        public UnidadeFederativa(int id, string sigla)
        {
            Id = id;
            Sigla = sigla;
        }

        public string Sigla { get; set; }

        public virtual ICollection<Cidade> ListaCidade { get; set; }

    }
}
