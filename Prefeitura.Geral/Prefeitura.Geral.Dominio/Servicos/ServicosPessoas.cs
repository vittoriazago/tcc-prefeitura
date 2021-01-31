using Microsoft.EntityFrameworkCore;
using Prefeitura.Geral.Dominio.Dominio;
using Prefeitura.Geral.Dominio.Dominio.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Dominio.Servicos
{
    public class ServicosPessoas
    {
        private readonly ContextoPrefeitura _contexto;

        public ServicosPessoas(ContextoPrefeitura contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Nova pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        public async Task<Pessoa> AdicionarPessoa(Pessoa pessoa)
        {
            await _contexto.AddAsync(pessoa);
            await _contexto.SaveChangesAsync();
            return pessoa;
        }
        public async Task<Pessoa> BuscarPessoaPorId(int id)
        {
            return await _contexto.Pessoas.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
