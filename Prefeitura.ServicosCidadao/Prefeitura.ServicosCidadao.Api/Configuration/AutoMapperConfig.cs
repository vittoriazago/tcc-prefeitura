using AutoMapper;
using Prefeitura.ServicosCidadao.Api.Models;
using Prefeitura.ServicosCidadao.Dominio.Dominio.Agendamentos;
using Prefeitura.ServicosCidadao.Dominio.Dominio.Blog;
using Prefeitura.ServicosCidadao.Dominio.Dominio.Financeiro;
using System.Collections.Generic;
using System.Linq;

namespace Prefeitura.ServicosCidadao.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<FuncionarioRequestDto, Funcionario>()
               .ForMember(f => f.ListaHistorico, r => r.MapFrom(f => new List<FuncionarioHistorico>
               {
                   new FuncionarioHistorico()
                   {
                       Situacao = f.Situacao,
                       IdUsuario = 1
                   }
               }));
            CreateMap<Funcionario, FuncionarioResponseDto>()
              .ForMember(f => f.Situacao, r => r.MapFrom(f => f.Situacao));


            CreateMap<Agendamento, AgendamentoResponseDto>();

            CreateMap<AgendamentoSolicitacaoRequestDto, AgendamentoSolicitacao>()
               .ForMember(f => f.ListaHistorico, r => r.MapFrom(f => new List<AgendamentoSolicitacaoHistorico>
               {
                   new AgendamentoSolicitacaoHistorico()
                   {
                       Situacao = f.Situacao,
                       IdUsuario = 1
                   }
               }));

            CreateMap<AgendamentoSolicitacao, AgendamentoSolicitacao>();


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