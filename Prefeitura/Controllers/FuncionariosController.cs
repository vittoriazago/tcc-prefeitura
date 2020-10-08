using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prefeitura.Models;
using Prefeitura.Negocio.Dominio.Financeiro;
using Prefeitura.Negocio.Servicos;

namespace Prefeitura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly ILogger<FuncionariosController> _logger;
        private readonly ServicosFuncionarios _servicosFuncionario;
        private readonly IMapper _mapper;

        public FuncionariosController(
            IMapper mapper,
            ServicosFuncionarios servicosFuncionario,
            ILogger<FuncionariosController> logger)
        {
            _servicosFuncionario = servicosFuncionario;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Buscar funcionarios por filtros
        /// </summary>
        /// <param name="numeroPagina"></param>
        /// <param name="tamanhoPagina"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var funcionarios = await _servicosFuncionario.Buscar(numeroPagina, tamanhoPagina);
            return Ok(_mapper.Map<IEnumerable<FuncionarioResponseDto>>(funcionarios.funcionarios.ToList()));
        }


        /// <summary>
        /// Buscar pontos funcionario
        /// </summary>
        /// <param name="id">Id funcionario</param>
        /// <param name="periodoInicial"></param>
        /// <param name="periodoFinal"></param>
        /// <returns></returns>
        [HttpGet("{id}/ponto")]
        public async Task<IActionResult> GetPontos(
           [FromRoute] int id,
            DateTime periodoInicial,
            DateTime periodoFinal)
        {
            var pontos = await _servicosFuncionario.BuscarPontos(id, periodoInicial, periodoFinal);
            return Ok(pontos.Select(p => p.DataHoraCadastro));
        }

        /// <summary>
        /// Criar funcionario
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(
           FuncionarioRequestDto body)
        {
            var funcionario = await _servicosFuncionario.AdicionarFuncionario(_mapper.Map<Funcionario>(body));
            return Created("", _mapper.Map<FuncionarioResponseDto>(funcionario));
        }

        /// <summary>
        /// Criar holerite
        /// </summary>
        /// <param name="id">Id funcionario</param>
        /// <param name="arquivo"></param>
        /// <returns></returns>
        [HttpPost("{id}/holerite")]
        public async Task<IActionResult> PutHolerite(
           [FromRoute] int id, 
           IFormFile arquivo)
        {
            byte[] bytesArquivo;
            using (var memoryStream = new MemoryStream())
            {
                await arquivo.CopyToAsync(memoryStream);
                bytesArquivo = memoryStream.ToArray();
            }

            await _servicosFuncionario.AdicionarHolerite(id, bytesArquivo);
            return Ok();
        }

        /// <summary>
        /// Criar ponto
        /// </summary>
        /// <param name="id">Id funcionario</param>
        /// <returns></returns>
        [HttpPost("{id}/ponto")]
        public async Task<IActionResult> PutHolerite([FromRoute] int id)
        {
            await _servicosFuncionario.AdicionarPontoRegistro(id);
            return Ok();
        }
    }
}
