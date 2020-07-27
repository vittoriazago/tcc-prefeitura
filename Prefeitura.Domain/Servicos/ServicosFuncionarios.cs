using Microsoft.EntityFrameworkCore;
using Prefeitura.Negocio.Dominio.Blog;
using Prefeitura.Negocio.Dominio.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        /// Buscar noticias por paginadas
        /// </summary>
        /// <param name="numeroPagina">Número da página</param>
        /// <param name="tamanhoPagina">Tamanho da página</param>
        /// <returns></returns>
        public async Task<(int quantidadeTotal, IEnumerable<Funcionario> noticias)> Buscar(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var funcionarios = _contexto.Funcionarios.AsQueryable();

            var quantidadeTotal = await funcionarios.CountAsync();
            if (tamanhoPagina.HasValue)
            {
                if (numeroPagina > 1)
                    funcionarios = funcionarios.Skip((numeroPagina - 1) * tamanhoPagina.Value);

                funcionarios = funcionarios.Take(tamanhoPagina.Value);
            }
            return (quantidadeTotal, funcionarios);
        }

    }
}
