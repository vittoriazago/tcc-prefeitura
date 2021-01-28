using System.ComponentModel.DataAnnotations.Schema;

namespace Prefeitura.ServicosCidadao.Dominio.Dominio
{
    public class Cidade : Entidade
    {
        public Cidade()
        {
        }

        public Cidade(int id, string descricao, int idUnidadeFederativa)
        {
            Id = id;
            Descricao = descricao;
            IdUnidadeFederativa = idUnidadeFederativa;
        }

        public string Descricao { get; set; }
        public int IdUnidadeFederativa { get; set; }

        [ForeignKey("IdUnidadeFederativa")]
        public virtual UnidadeFederativa UnidadeFederativa { get; set; }

    }
}
