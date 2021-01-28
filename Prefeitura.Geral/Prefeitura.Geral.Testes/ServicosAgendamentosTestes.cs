using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prefeitura.Geral.Dominio;
using Prefeitura.Geral.Dominio.Servicos;

namespace Prefeitura.Geral.Testes
{
    [TestClass]
    public class ServicosAgendamentosTestes
    {
        private ServicosAgendamentos _servicosAgendamentos;
        private ContextoPrefeitura _contexto;

        [TestInitialize]
        public void Init()
        {
            _contexto = MockContext.GetDatabaseContext().Result;
            _servicosAgendamentos = new ServicosAgendamentos(_contexto);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
