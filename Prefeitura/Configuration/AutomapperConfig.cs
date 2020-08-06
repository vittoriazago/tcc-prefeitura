using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Prefeitura.Models;
using Prefeitura.Negocio.Dominio.Financeiro;
using Prefeitura.Negocio.Dominio.Agendamentos;
using Prefeitura.Negocio.Dominio.Blog;
using Prefeitura.Negocio.Dominio.Saude;

namespace Prefeitura.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Funcionario, FuncionariosResponseDto>();
              //  .ForMember(f => f.Situacao, r => r.MapFrom(f => f.sit));
            CreateMap<Agendamento, AgendamentoResponseDto>();
            CreateMap<ConsultaAtendimento, ConsultaAtendimentoResponseDto>();
            CreateMap<Noticia, NoticiaResponseDto>();
        }
    }
}