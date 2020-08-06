using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prefeitura.Models;
using Prefeitura.Negocio.Servicos;

namespace Prefeitura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendamentosController : ControllerBase
    {
        private readonly ILogger<AgendamentosController> _logger;
        private readonly ServicosAgendamentos _servicosAgendamento;
        private readonly IMapper _mapper;

        public AgendamentosController(
            IMapper mapper,
            ServicosAgendamentos servicosAgendamento,
            ILogger<AgendamentosController> logger)
        {
            _servicosAgendamento = servicosAgendamento;
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
    }
}
