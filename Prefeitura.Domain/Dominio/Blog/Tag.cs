using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Blog
{
    public class Tag : Entidade
    {
        public string NomeTag { get; set; }


        public virtual ICollection<NoticiaTag> ListaNoticiaTag { get; set; }
    }
}
