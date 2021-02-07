using Prefeitura.Geral.Dominio.Dominio.Enums;
using System;
using System.Collections.Generic;

namespace Prefeitura.Geral.Api.Models
{
    public class IptuResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int Ano { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public List<IptuOpcoesResponseDto> OpcoesPagamento { get; set; }
    }
    public class IptuOpcoesResponseDto
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
