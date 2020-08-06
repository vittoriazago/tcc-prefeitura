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
    public class NoticiasController : ControllerBase
    {
        private readonly ILogger<NoticiasController> _logger;
        private readonly ServicosBlog _servicosNoticias;
        private readonly IMapper _mapper;

        public NoticiasController(
            IMapper mapper,
            ServicosBlog servicosNoticias,
            ILogger<NoticiasController> logger)
        {
            _servicosNoticias = servicosNoticias;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Buscar noticias por filtros
        /// </summary>
        /// <param name="numeroPagina"></param>
        /// <param name="tamanhoPagina"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(
            int numeroPagina = 1,
            int? tamanhoPagina = null)
        {
            var noticias = await _servicosNoticias.Buscar(numeroPagina, tamanhoPagina);
            return Ok(_mapper.Map<IEnumerable<NoticiaResponseDto>>(noticias.noticias));
        }
    }
}
