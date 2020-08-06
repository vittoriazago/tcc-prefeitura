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
            return Ok(_mapper.Map<IEnumerable<FuncionariosResponseDto>>(funcionarios.funcionarios));
        }
    }
}
