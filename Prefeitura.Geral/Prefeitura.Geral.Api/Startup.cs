using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Prefeitura.Geral.Api.Configuration;
using Prefeitura.Geral.Dominio;
using Prefeitura.Geral.Dominio.Servicos;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace Prefeitura.Geral.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(
                options => options.AddPolicy("AllowCors",
                builder =>
                {
                    builder
                        .WithOrigins("*")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                })
            );

            services.AddDbContext<ContextoPrefeitura>(options =>
                              //options.UseSqlServer(
                              //    Configuration.GetConnectionString("DefaultConnection"))
                              options.UseInMemoryDatabase(databaseName: "TESTE")
                              );

            services.ConfigureAuthentication(Configuration.GetSection("AppSettings:Token").Value);

            services.AddMvc()
                    .AddNewtonsoftJson(o =>
                    {
                        o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        o.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    })
                    .AddJsonOptions(opt =>
                    {
                        opt.JsonSerializerOptions.PropertyNamingPolicy = null;
                        opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                        opt.JsonSerializerOptions.IgnoreNullValues = true;
                    });

            services.AddScoped<ServicosBlog>();
            services.AddScoped<ServicosAgendamentos>();
            services.AddScoped<ServicosAgendamentosSolicitacoes>();
            services.AddScoped<ServicosFuncionarios>();
            services.AddScoped<ServicosPessoas>();

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                // Configura a documenta��o do swagger
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Prefeitura Api",
                        Version = "v1",
                        Description = "Service representing ASPNET CORE",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Vittoria Zago",
                        }
                    });

                // configura o xml
                var caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var nomeAplicacao =
                    PlatformServices.Default.Application.ApplicationName;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");

                // adiciona a autoriza��o e os coment�rios pelo xml
                c.IncludeXmlComments(caminhoXmlDoc);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prefeitura V1");
            });


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseCors("AllowCors");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

        }
    }
}
