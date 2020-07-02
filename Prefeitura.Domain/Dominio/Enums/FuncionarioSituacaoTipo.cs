using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Enums
{
    public enum FuncionarioSituacaoTipo : byte
    {
        Vigente = 1,
        Afastado = 2,
        Ferias = 3,
        Desligado = 4
    }
}
