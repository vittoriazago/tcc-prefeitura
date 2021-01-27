using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Suporte
{
    public class SuporteSolicitacao : Entidade
    {
        public int IdCidade { get; set; }
        public int IdPessoa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Solicitacao { get; set; }


        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }

        [ForeignKey("IdCidade")]
        public virtual Cidade Cidade { get; set; }
    }
}
