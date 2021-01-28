using System;

namespace Prefeitura.Geral.Dominio.Dominio
{
    public class Pessoa : Entidade
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}
