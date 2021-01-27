using Microsoft.EntityFrameworkCore;
using Prefeitura.Negocio.Dominio.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Buscar pontos de funcionario
        /// </summary>
        /// <param name="idFuncionario"></param>
        /// <param name="periodoInicial"></param>
        /// <param name="periodoFinal"></param>
        /// <returns></returns>
        public Task<List<PontoRegistro>> BuscarPontos(int idFuncionario, DateTime periodoInicial, DateTime periodoFinal)
        {
            return _contexto.FuncionarioPontoRegistros.AsQueryable()
                        .Where(p => p.IdFuncionario == idFuncionario
                                && p.DataHoraCadastro >= periodoInicial
                                && p.DataHoraCadastro <= periodoFinal).ToListAsync();
        }

        /// <summary>
        /// Novo funcionario
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        public async Task<Funcionario> AdicionarFuncionario(Funcionario funcionario)
        {
            await _contexto.AddAsync(funcionario);
            await _contexto.SaveChangesAsync();

            await _contexto.AddAsync(new FuncionarioHistorico()
            {
                IdFuncionario = funcionario.Id,
                Ativo = true,
                DataHora = DateTime.Now,
                Situacao = funcionario.ListaHistorico.First().Situacao,
                IdUsuario = funcionario.ListaHistorico.First().IdUsuario,

            });
            await _contexto.SaveChangesAsync();

            return funcionario;
        }

        /// <summary>
        /// Novo holerite
        /// </summary>
        /// <param name="holerite"></param>
        /// <returns></returns>
        public async Task AdicionarHolerite(int id, byte[] bytesArquivo)
        {
            await _contexto.AddAsync(new Holerite()
            {
                IdFuncionario = id,
                DataHoraCadastro = DateTime.Now,
                Arquivo = bytesArquivo

            });
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// Novo registro de ponto
        /// </summary>
        /// <param name="ponto"></param>
        /// <returns></returns>
        public async Task AdicionarPontoRegistro(int idFuncionario)
        {
            await _contexto.AddAsync(new PontoRegistro()
            {
                IdFuncionario = idFuncionario,
                DataHoraCadastro = DateTime.Now,

            });
            await _contexto.SaveChangesAsync();

        }
    }
}
