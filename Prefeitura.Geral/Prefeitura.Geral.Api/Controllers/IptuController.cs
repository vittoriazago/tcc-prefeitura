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
    public class IptuController : ControllerBase
    {
        private readonly ILogger<IptuController> _logger;
        private readonly IMapper _mapper;

        public IptuController(
            IMapper mapper,
            ILogger<IptuController> logger)
        {
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Buscar Iptu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(string documento)
        {
            // metodo mockado para POC 
            var valorTotal = 225M;
            var hoje = DateTime.Today;
            var opcoes = new List<IptuOpcoesResponseDto>();
            for (int indice = 1; indice <=3; indice++)
            {
                var novoValor = valorTotal + ((indice-1) * 1.7M);
                opcoes.Add(new IptuOpcoesResponseDto()
                {
                    Quantidade = indice,
                    ValorTotal = novoValor,
                    ValorParcela = Math.Round(novoValor / indice, 2),
                    DataVencimento = hoje.AddMonths(indice)
                });
            }

            var response = new IptuResponseDto()
            {
                Ano = 2021,
                Documento = "493.122.654-22",
                Nome = "Mariete de Souza Barros",
                Cep = "17129-001",
                Logradouro = "Rua Carlos Filho 3-40, Centro",
                Tipo = "CASA",
                Valor = valorTotal,
                OpcoesPagamento = opcoes
            };
            return Ok(response);
        }
    }
}
