﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class Visualizacao : Entidade
    {
        public Guid IdNoticia { get; set; }
        public DateTime DataHora { get; set; }


        public Noticia Noticia { get; set; }
    }
}
