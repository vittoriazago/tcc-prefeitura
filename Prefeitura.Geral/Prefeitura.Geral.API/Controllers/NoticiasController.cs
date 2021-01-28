using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prefeitura.Geral.Api.Models;
using Prefeitura.Geral.Dominio.Dominio.Blog;
using Prefeitura.Geral.Dominio.Dominio.Enums;
using Prefeitura.Geral.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Api.Controllers
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
        /// Buscar noticia por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var noticia = await _servicosNoticias.Buscar(id);
            return Ok(_mapper.Map<NoticiaResponseDto>(noticia));
        }

        /// <summary>
        /// Buscar noticias por filtros
        /// </summary>
        /// <param name="numeroPagina"></param>
        /// <param name="tamanhoPagina"></param>
        /// <param name="situacao"></param>
        /// <param name="dataFinal"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(
            int numeroPagina = 1,
            int? tamanhoPagina = null,
            NoticiaSituacaoTipo? situacao = null,
            DateTime? dataFinal = null)
        {
            var noticias = await _servicosNoticias.Buscar(numeroPagina, tamanhoPagina, situacao, dataFinal);
            return Ok(_mapper.Map<IEnumerable<NoticiaResponseDto>>(noticias.noticias.ToList()));
        }

        /// <summary>
        /// Criar nova noticia
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(
           NoticiaRequestDto body)
        {
            var noticia = await _servicosNoticias.AdicionarNoticia(_mapper.Map<Noticia>(body));
            return Created("", _mapper.Map<NoticiaResponseDto>(noticia));
        }
    }
}
