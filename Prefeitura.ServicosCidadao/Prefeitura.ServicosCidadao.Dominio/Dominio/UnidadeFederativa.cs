using System.Collections.Generic;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio
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
