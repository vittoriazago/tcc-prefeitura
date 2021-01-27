using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio
{
    public class Pessoa : Entidade
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
