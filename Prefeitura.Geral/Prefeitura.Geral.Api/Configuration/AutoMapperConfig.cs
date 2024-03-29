﻿using AutoMapper;
using Prefeitura.Geral.Api.Models;
using Prefeitura.Geral.Api.Models.Usuarios;
using Prefeitura.Geral.Dominio.Dominio;
using Prefeitura.Geral.Dominio.Dominio.Agendamentos;
using Prefeitura.Geral.Dominio.Dominio.Blog;
using Prefeitura.Geral.Dominio.Dominio.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prefeitura.Geral.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UsuarioNovoDto, Usuario>()
              .ForMember(f => f.UserName, r => r.MapFrom(f => f.Email))
              .ForMember(f => f.Ativo, r => r.MapFrom(f => true))
              .ForMember(f => f.DataCadastro, r => r.MapFrom(f => DateTime.Now))
              .ForMember(f => f.Email, r => r.MapFrom(f => f.Email))
              .ForMember(f => f.NormalizedEmail, r => r.MapFrom(f => f.Email))
              .ForMember(f => f.NormalizedUserName, r => r.MapFrom(f => f.Email));

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