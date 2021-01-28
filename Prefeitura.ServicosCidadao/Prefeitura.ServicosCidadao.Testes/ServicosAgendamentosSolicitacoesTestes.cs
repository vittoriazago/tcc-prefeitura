using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prefeitura.ServicosCidadao.Dominio;
using Prefeitura.ServicosCidadao.Dominio.Dominio.Agendamentos;
using Prefeitura.ServicosCidadao.Dominio.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prefeitura.ServicosCidadao.Testes
{
    [TestClass]
    public class ServicosAgendamentosSolicitacoesTestes
    {
        private ServicosAgendamentosSolicitacoes _servicosAgendamentos;
        private ContextoPrefeitura _contexto;

        [TestInitialize]
        public void Init()
        {
            _contexto = MockContext.GetDatabaseContext().Result;
            _servicosAgendamentos = new ServicosAgendamentosSolicitacoes(_contexto);
        }

        [TestMethod]
        public async Task TestMethod1()
        {
            await _servicosAgendamentos.AdicionarAgendamentoSolicitacao(
                new Dominio.Dominio.Agendamentos.AgendamentoSolicitacao()
                {
                    ListaHistorico = new List<AgendamentoSolicitacaoHistorico>()
                    {
                        new AgendamentoSolicitacaoHistorico()
                        {


                        }
                    }
                });
        }
    }
}
