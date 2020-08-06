using Prefeitura.Negocio.Dominio.Financeiro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prefeitura.Negocio.Servicos
{
    public class ServicosFuncionarios
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosFuncionarios(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Buscar funcionarios com paginacao
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IEnumerable<Funcionario> funcionarios)> Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var funcionarios = _contexto.Funcionarios.AsQueryable();

            return await funcionarios.Paginacao(numeroPagina, tamanhoPagina);
        }

    }
}
