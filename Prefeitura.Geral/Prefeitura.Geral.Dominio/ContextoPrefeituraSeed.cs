using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Prefeitura.Geral.Dominio.Dominio;
using Prefeitura.Geral.Dominio.Dominio.Agendamentos;
using Prefeitura.Geral.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prefeitura.Geral.Dominio
{
    public class ContextoPrefeituraSeed
    {
        private readonly UserManager<Usuario> _usuarioManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ServicosPessoas _servicosPessoas;

        public ContextoPrefeituraSeed(UserManager<Usuario> usuarioManager,
            RoleManager<Role> roleManager,
            ServicosPessoas servicosPessoas)
        {
            _roleManager = roleManager;
            _servicosPessoas = servicosPessoas;
            _usuarioManager = usuarioManager;
        }
        public async Task SeedInitialApi()
        {
            await SeedRole("sgm");
            await SeedUser(1, "sgm", "Vittoria Funcionária", "43244082374823", "funcionario@sgm.com.br", "sgm2021");

            await SeedRole("comum");
            await SeedUser(2, "comum", "Vittoria Municípe", "43244082374823", "vittoria.municipe@mail.com.br", "sgm2021");
        }
        public async Task SeedRole(string roleName)
        {
            var role = new Role
            {
                Name = roleName
            };
            await _roleManager.CreateAsync(role);
        }
        public async Task SeedUser(int id, string role, string nome, string documento, string email, string senha)
        {
            var pessoa = new Pessoa
            {
                Id = id,
                Nome = nome,
                Documento = documento,
                DataNascimento = DateTime.Today.AddYears(-20)
            };
            await _servicosPessoas.AdicionarPessoa(pessoa);

            var usuarioNovo = new Usuario
            {
                Id = id,
                UserName = email,
                NormalizedUserName = email,
                Email = email,
                NormalizedEmail = email,
                EmailConfirmed = true,
                IdPessoa = id,
                DataCadastro = DateTime.Now,
                Ativo = true,
            };
            var userResult = await _usuarioManager.CreateAsync(usuarioNovo, senha);
            if (userResult.Succeeded)
            {
                await _usuarioManager.AddToRoleAsync(usuarioNovo, role);
            }
        }
        public void SeedUFsCidades(ModelBuilder modelBuilder)
        {
            var dados = new List<(UnidadeFederativa, Cidade)>()
            {
                (new UnidadeFederativa(1, "MG"), new Cidade(1, "BAURU", 1 )),
                (new UnidadeFederativa(2, "SP"), new Cidade(2, "BELO HORIZONTE", 2 ))
            };

            dados.ForEach(uf =>
            {
                modelBuilder.Entity<UnidadeFederativa>().HasData(uf.Item1);
                modelBuilder.Entity<Cidade>().HasData(uf.Item2);
            });
        }
        public void SeedAgendamentos(ModelBuilder modelBuilder)
        {
            var dados = new List<Agendamento>()
            {
                new Agendamento(1, "Solicitar carteira de trabalho", DateTime.Now, DateTime.Now.AddHours(3)),
                new Agendamento(2, "Minha casa minha vida", DateTime.Now, DateTime.Now.AddHours(3))
            };

            dados.ForEach(ag =>
            {
                modelBuilder.Entity<Agendamento>().HasData(ag);
            });
        }
    }
}
