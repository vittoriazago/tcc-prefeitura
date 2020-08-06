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
    public class SaudeController : ControllerBase
    {
        private readonly ILogger<SaudeController> _logger;
        private readonly ServicosConsultasMedicas _servicosConsultaAtendimento;
        private readonly IMapper _mapper;

        public SaudeController(
            IMapper mapper,
            ServicosConsultasMedicas servicosConsultaAtendimento,
            ILogger<SaudeController> logger)
        {
            _servicosConsultaAtendimento = servicosConsultaAtendimento;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Buscar consultas atendimentos por filtros
        /// </summary>
        /// <param name="numeroPagina"></param>
        /// <param name="tamanhoPagina"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(
            int numeroPagina = 1,
            int? tamanhoPagina = null) 
        {
            var consultaAtendimentos = await _servicosConsultaAtendimento.Buscar(numeroPagina, tamanhoPagina);
            return Ok(_mapper.Map<IEnumerable<ConsultaAtendimentoResponseDto>>(consultaAtendimentos.consultas));
        }
    }
}
