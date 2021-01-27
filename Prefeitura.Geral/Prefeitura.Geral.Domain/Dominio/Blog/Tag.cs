using System.Collections.Generic;

namespace Prefeitura.Geral.Negocio.Dominio.Blog
{
    public class Tag : Entidade
    {
        public string NomeTag { get; set; }


        public virtual ICollection<NoticiaTag> ListaNoticiaTag { get; set; }
    }
}
