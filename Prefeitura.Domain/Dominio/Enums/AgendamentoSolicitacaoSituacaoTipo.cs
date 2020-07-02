using System;
using System.Collections.Generic;
using System.Text;

namespace Prefeitura.Negocio.Dominio.Enums
{
    public enum AgendamentoSolicitacaoSituacaoTipo : byte
    {
        Pendente = 1,
        EmAndamento = 2,
        Finalizada = 3,
        Cancelada = 4,
        Feedback = 5,
    }
}
