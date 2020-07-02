using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Enums
{
    public enum FuncionarioContratacaoTipo : byte
    {
        Eleicao = 1,
        Concurso = 2,
        Licitacao = 3,
        PJ = 4,
        CLT = 5,
    }
}
