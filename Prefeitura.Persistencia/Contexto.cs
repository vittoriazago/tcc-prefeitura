﻿
using Microsoft.EntityFrameworkCore;
using Prefeitura.Negocio.Dominio.Agendamentos;
using Prefeitura.Negocio.Dominio.Blog;
using Prefeitura.Negocio.Dominio.Financeiro;
using Prefeitura.Negocio.Dominio.Saude;
using Prefeitura.Negocio.Dominio.Suporte;

namespace Prefeitura.Persistencia
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<AgendamentoHistorico> AgendamentoHistoricos { get; set; }
        public DbSet<AgendamentoSolicitacao> AgendamentoSolicitacao { get; set; }
        public DbSet<AgendamentoSolicitacaoHistorico> AgendamentoSolicitacaoHistoricos { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<NoticiaAutor> NoticiaAutores { get; set; }
        public DbSet<NoticiaCidade> NoticiaCidades { get; set; }
        public DbSet<NoticiaHistorico> NoticiaHistorico { get; set; }
        public DbSet<Tag> Tags { get; set; }


        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioHistorico> FuncionarioHistoricos { get; set; }
        public DbSet<Holerite> FuncionarioHolerites { get; set; }
        public DbSet<PontoRegistro> FuncionarioPontoRegistros { get; set; }


        public DbSet<ConsultaAtendimento> ConsultaAtendimento { get; set; }
        public DbSet<ConsultaAtendimentoSaida> ConsultaAtendimentoSaida { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Medico> Medico { get; set; }

        public DbSet<SuporteSolicitacao> SuporteSolicitacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}