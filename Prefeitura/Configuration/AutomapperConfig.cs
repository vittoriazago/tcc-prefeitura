using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Prefeitura.Models;
using Prefeitura.Negocio.Dominio.Financeiro;
using Prefeitura.Negocio.Dominio.Agendamentos;
using Prefeitura.Negocio.Dominio.Blog;
using Prefeitura.Negocio.Dominio.Saude;
using Prefeitura.Negocio.Dominio.Enums;
using System.Collections.Generic;
using System.Linq;

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


            CreateMap<Noticia, NoticiaResponseDto>()
              .ForMember(f => f.NomesAutores, r => r.MapFrom((f, s) => f.ListaAutor.Select(a => a.Autor?.Nome)));

            CreateMap<NoticiaRequestDto, Noticia>()
               .ForMember(f => f.ListaHistorico, r => r.MapFrom(f => new List<NoticiaHistorico>
               {
                   new NoticiaHistorico()
                   {
                       Situacao = f.NoticiaSituacaoTipo,
                       IdUsuario = 1
                   }
               }))
               .ForMember(f => f.ListaCidade, r => r.MapFrom(f => f.IdsCidades.Select(
                   id => new NoticiaCidade()
                   {
                       IdCidade = id,
                   }
               )))
               .ForMember(f => f.ListaAutor, r => r.MapFrom(f => f.IdsAutores.Select(
                   id => new NoticiaAutor()
                   {
                       IdAutor = id,
                   }
               )));
        }
    }
}