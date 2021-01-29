using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prefeitura.Geral.Api.Models;
using Prefeitura.Geral.Dominio.Dominio.Agendamentos;
using Prefeitura.Geral.Dominio.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendamentosController : ControllerBase
    {
        private readonly ILogger<AgendamentosController> _logger;
        private readonly ServicosAgendamentos _servicosAgendamento;
        private readonly ServicosAgendamentosSolicitacoes _servicosAgendamentoSolicitacao;
        private readonly IMapper _mapper;

        public AgendamentosController(
            IMapper mapper,
            ServicosAgendamentos servicosAgendamento,
            ServicosAgendamentosSolicitacoes servicosAgendamentoSolicitacao,
            ILogger<AgendamentosController> logger)
        {
            _servicosAgendamento = servicosAgendamento;
            _servicosAgendamentoSolicitacao = servicosAgendamentoSolicitacao;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Buscar agendamentos por filtros
        /// </summary>
        /// <param name="numeroPagina"></param>
        /// <param name="tamanhoPagina"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var agendamentos = await _servicosAgendamento.Buscar(numeroPagina, tamanhoPagina);
            return Ok(_mapper.Map<IEnumerable<AgendamentoResponseDto>>(agendamentos.agendamentos));
        }

        /// <summary>
        /// Criar novo agendamento
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(
           AgendamentoSolicitacaoRequestDto body)
        {
            var consulta = await _servicosAgendamentoSolicitacao.AdicionarAgendamentoSolicitacao(_mapper.Map<AgendamentoSolicitacao>(body));
            return Created("", _mapper.Map<AgendamentoSolicitacaoResponseDto>(consulta));
        }
    }
}
