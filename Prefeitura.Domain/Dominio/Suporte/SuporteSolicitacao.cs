using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Suporte
{
    public class SuporteSolicitacao : Entidade
    {
        public Guid IdCidade { get; set; }
        public Guid IdPessoa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Solicitacao { get; set; }


        public Pessoa Pessoa { get; set; }
        public Cidade Cidade { get; set; }
    }
}
