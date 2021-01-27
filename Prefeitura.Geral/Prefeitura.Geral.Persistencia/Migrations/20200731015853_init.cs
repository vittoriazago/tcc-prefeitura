using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Prefeitura.Geral.Persistencia.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGENDAMENTOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true),
                    DATAHORADISPONIVELINICIAL = table.Column<DateTime>(nullable: false),
                    DATAHORADISPONIVELFINAL = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDAMENTOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NOTICIAS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true),
                    CONTEUDOHTML = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICIAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOCUMENTO = table.Column<string>(nullable: true),
                    NOME = table.Column<string>(nullable: true),
                    DATANASCIMENTO = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ROLE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(nullable: true),
                    NORMALIZEDNAME = table.Column<string>(nullable: true),
                    CONCURRENCYSTAMP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TAGS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMETAG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAGS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UNIDADEFEDERATIVA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIGLA = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNIDADEFEDERATIVA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "COMENTARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(nullable: true),
                    CONTEUDO = table.Column<string>(nullable: true),
                    IDNOTICIA = table.Column<int>(nullable: false),
                    DATAHORA = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMENTARIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_COMENTARIOS_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VISUALIZACAO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNOTICIA = table.Column<int>(nullable: false),
                    DATAHORA = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISUALIZACAO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VISUALIZACAO_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "NOTICIAAUTORES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAUTOR = table.Column<int>(nullable: false),
                    IDNOTICIA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICIAAUTORES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NOTICIAAUTORES_PESSOA_IDAUTOR",
                        column: x => x.IDAUTOR,
                        principalTable: "PESSOA",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NOTICIAAUTORES_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(nullable: true),
                    NORMALIZEDUSERNAME = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    NORMALIZEDEMAIL = table.Column<string>(nullable: true),
                    EMAILCONFIRMED = table.Column<bool>(nullable: false),
                    PASSWORDHASH = table.Column<string>(nullable: true),
                    SECURITYSTAMP = table.Column<string>(nullable: true),
                    CONCURRENCYSTAMP = table.Column<string>(nullable: true),
                    PHONENUMBER = table.Column<string>(nullable: true),
                    PHONENUMBERCONFIRMED = table.Column<bool>(nullable: false),
                    TWOFACTORENABLED = table.Column<bool>(nullable: false),
                    LOCKOUTEND = table.Column<DateTimeOffset>(nullable: true),
                    LOCKOUTENABLED = table.Column<bool>(nullable: false),
                    ACCESSFAILEDCOUNT = table.Column<int>(nullable: false),
                    IDPESSOA = table.Column<int>(nullable: false),
                    DATACADASTRO = table.Column<DateTime>(nullable: false),
                    ATIVO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USUARIO_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "NOTICIATAG",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNOTICIA = table.Column<int>(nullable: false),
                    IDTAG = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICIATAG", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NOTICIATAG_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NOTICIATAG_TAGS_IDTAG",
                        column: x => x.IDTAG,
                        principalTable: "TAGS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CIDADE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true),
                    IDUNIDADEFEDERATIVA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIDADE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CIDADE_UNIDADEFEDERATIVA_IDUNIDADEFEDERATIVA",
                        column: x => x.IDUNIDADEFEDERATIVA,
                        principalTable: "UNIDADEFEDERATIVA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AGENDAMENTOHISTORICOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAGENDAMENTO = table.Column<int>(nullable: false),
                    IDUSUARIO = table.Column<int>(nullable: false),
                    DATAHORA = table.Column<DateTime>(nullable: false),
                    SITUACAO = table.Column<byte>(nullable: false),
                    ATIVO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDAMENTOHISTORICOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOHISTORICOS_AGENDAMENTOS_IDAGENDAMENTO",
                        column: x => x.IDAGENDAMENTO,
                        principalTable: "AGENDAMENTOS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOHISTORICOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "NOTICIAHISTORICO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNOTICIA = table.Column<int>(nullable: false),
                    IDUSUARIO = table.Column<int>(nullable: false),
                    DATAHORA = table.Column<DateTime>(nullable: false),
                    SITUACAO = table.Column<byte>(nullable: false),
                    ATIVO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICIAHISTORICO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NOTICIAHISTORICO_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NOTICIAHISTORICO_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "USUARIOROLE",
                columns: table => new
                {
                    USERID = table.Column<int>(nullable: false),
                    ROLEID = table.Column<int>(nullable: false),
                    IDPESSOA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOROLE", x => new { x.USERID, x.ROLEID });
                    table.ForeignKey(
                        name: "FK_USUARIOROLE_ROLE_ROLEID",
                        column: x => x.ROLEID,
                        principalTable: "ROLE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_USUARIOROLE_USUARIO_USERID",
                        column: x => x.USERID,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AGENDAMENTOSOLICITACAO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OBSERVACAO = table.Column<string>(nullable: true),
                    PREFERENCIAL = table.Column<bool>(nullable: false),
                    SENHA = table.Column<int>(nullable: false),
                    IDAGENDAMENTO = table.Column<int>(nullable: false),
                    IDCIDADE = table.Column<int>(nullable: false),
                    IDPESSOA = table.Column<int>(nullable: false),
                    DATAHORAAGENDAMENTO = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDAMENTOSOLICITACAO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAO_AGENDAMENTOS_IDAGENDAMENTO",
                        column: x => x.IDAGENDAMENTO,
                        principalTable: "AGENDAMENTOS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAO_CIDADE_IDCIDADE",
                        column: x => x.IDCIDADE,
                        principalTable: "CIDADE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAO_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPESSOA = table.Column<int>(nullable: false),
                    IDCIDADE = table.Column<int>(nullable: false),
                    CONTRATACAO = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOS_CIDADE_IDCIDADE",
                        column: x => x.IDCIDADE,
                        principalTable: "CIDADE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOS_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HOSPITAL",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCIDADE = table.Column<int>(nullable: false),
                    NOMEHOSPITAL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOSPITAL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HOSPITAL_CIDADE_IDCIDADE",
                        column: x => x.IDCIDADE,
                        principalTable: "CIDADE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "NOTICIACIDADES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNOTICIA = table.Column<int>(nullable: false),
                    IDCIDADE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICIACIDADES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NOTICIACIDADES_CIDADE_IDCIDADE",
                        column: x => x.IDCIDADE,
                        principalTable: "CIDADE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NOTICIACIDADES_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SUPORTESOLICITACOES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCIDADE = table.Column<int>(nullable: false),
                    IDPESSOA = table.Column<int>(nullable: false),
                    EMAIL = table.Column<string>(nullable: true),
                    TELEFONE = table.Column<string>(nullable: true),
                    NOME = table.Column<string>(nullable: true),
                    SOLICITACAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUPORTESOLICITACOES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SUPORTESOLICITACOES_CIDADE_IDCIDADE",
                        column: x => x.IDCIDADE,
                        principalTable: "CIDADE",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SUPORTESOLICITACOES_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AGENDAMENTOSOLICITACAOHISTORICOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAGENDAMENTOSOLICITACAO = table.Column<int>(nullable: false),
                    IDUSUARIO = table.Column<int>(nullable: false),
                    DATAHORA = table.Column<DateTime>(nullable: false),
                    SITUACAO = table.Column<byte>(nullable: false),
                    ATIVO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENDAMENTOSOLICITACAOHISTORICOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_AGENDAMENTOSOLICITACAO_IDAGENDAMENTOSOLICITACAO",
                        column: x => x.IDAGENDAMENTOSOLICITACAO,
                        principalTable: "AGENDAMENTOSOLICITACAO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOHISTORICOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDFUNCIONARIO = table.Column<int>(nullable: false),
                    IDUSUARIO = table.Column<int>(nullable: false),
                    DATAHORA = table.Column<DateTime>(nullable: false),
                    SITUACAO = table.Column<byte>(nullable: false),
                    ATIVO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOHISTORICOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOHISTORICOS_FUNCIONARIOS_IDFUNCIONARIO",
                        column: x => x.IDFUNCIONARIO,
                        principalTable: "FUNCIONARIOS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOHISTORICOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOHOLERITES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDFUNCIONARIO = table.Column<int>(nullable: false),
                    DATAHORACADASTRO = table.Column<DateTime>(nullable: false),
                    ARQUIVO = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOHOLERITES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOHOLERITES_FUNCIONARIOS_IDFUNCIONARIO",
                        column: x => x.IDFUNCIONARIO,
                        principalTable: "FUNCIONARIOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIOPONTOREGISTROS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDFUNCIONARIO = table.Column<int>(nullable: false),
                    DATAHORACADASTRO = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIOPONTOREGISTROS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOPONTOREGISTROS_FUNCIONARIOS_IDFUNCIONARIO",
                        column: x => x.IDFUNCIONARIO,
                        principalTable: "FUNCIONARIOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MEDICO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDFUNCIONARIO = table.Column<int>(nullable: false),
                    CRM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEDICO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MEDICO_FUNCIONARIOS_IDFUNCIONARIO",
                        column: x => x.IDFUNCIONARIO,
                        principalTable: "FUNCIONARIOS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONSULTAATENDIMENTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHOSPITAL = table.Column<int>(nullable: false),
                    IDPESSOA = table.Column<int>(nullable: false),
                    IDMEDICO = table.Column<int>(nullable: false),
                    DATAHORAINICIAL = table.Column<DateTime>(nullable: false),
                    DATAHORAFINAL = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSULTAATENDIMENTO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONSULTAATENDIMENTO_HOSPITAL_IDHOSPITAL",
                        column: x => x.IDHOSPITAL,
                        principalTable: "HOSPITAL",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CONSULTAATENDIMENTO_MEDICO_IDMEDICO",
                        column: x => x.IDMEDICO,
                        principalTable: "MEDICO",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CONSULTAATENDIMENTO_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CONSULTAATENDIMENTOSAIDA",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCONSULTAATENDIMENTO = table.Column<int>(nullable: false),
                    OBSERVACAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSULTAATENDIMENTOSAIDA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CONSULTAATENDIMENTOSAIDA_CONSULTAATENDIMENTO_IDCONSULTAATENDIMENTO",
                        column: x => x.IDCONSULTAATENDIMENTO,
                        principalTable: "CONSULTAATENDIMENTO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOHISTORICOS_IDAGENDAMENTO",
                table: "AGENDAMENTOHISTORICOS",
                column: "IDAGENDAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOHISTORICOS_IDUSUARIO",
                table: "AGENDAMENTOHISTORICOS",
                column: "IDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOSOLICITACAO_IDAGENDAMENTO",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDAGENDAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOSOLICITACAO_IDCIDADE",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDCIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOSOLICITACAO_IDPESSOA",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDPESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOSOLICITACAOHISTORICOS_IDAGENDAMENTOSOLICITACAO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS",
                column: "IDAGENDAMENTOSOLICITACAO");

            migrationBuilder.CreateIndex(
                name: "IX_AGENDAMENTOSOLICITACAOHISTORICOS_IDUSUARIO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS",
                column: "IDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_CIDADE_IDUNIDADEFEDERATIVA",
                table: "CIDADE",
                column: "IDUNIDADEFEDERATIVA");

            migrationBuilder.CreateIndex(
                name: "IX_COMENTARIOS_IDNOTICIA",
                table: "COMENTARIOS",
                column: "IDNOTICIA");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAATENDIMENTO_IDHOSPITAL",
                table: "CONSULTAATENDIMENTO",
                column: "IDHOSPITAL");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAATENDIMENTO_IDMEDICO",
                table: "CONSULTAATENDIMENTO",
                column: "IDMEDICO");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAATENDIMENTO_IDPESSOA",
                table: "CONSULTAATENDIMENTO",
                column: "IDPESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_CONSULTAATENDIMENTOSAIDA_IDCONSULTAATENDIMENTO",
                table: "CONSULTAATENDIMENTOSAIDA",
                column: "IDCONSULTAATENDIMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOHISTORICOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHISTORICOS",
                column: "IDFUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOHISTORICOS_IDUSUARIO",
                table: "FUNCIONARIOHISTORICOS",
                column: "IDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOHOLERITES_IDFUNCIONARIO",
                table: "FUNCIONARIOHOLERITES",
                column: "IDFUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOPONTOREGISTROS_IDFUNCIONARIO",
                table: "FUNCIONARIOPONTOREGISTROS",
                column: "IDFUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOS_IDCIDADE",
                table: "FUNCIONARIOS",
                column: "IDCIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIOS_IDPESSOA",
                table: "FUNCIONARIOS",
                column: "IDPESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_HOSPITAL_IDCIDADE",
                table: "HOSPITAL",
                column: "IDCIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_MEDICO_IDFUNCIONARIO",
                table: "MEDICO",
                column: "IDFUNCIONARIO");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIAAUTORES_IDAUTOR",
                table: "NOTICIAAUTORES",
                column: "IDAUTOR");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIAAUTORES_IDNOTICIA",
                table: "NOTICIAAUTORES",
                column: "IDNOTICIA");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIACIDADES_IDCIDADE",
                table: "NOTICIACIDADES",
                column: "IDCIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIACIDADES_IDNOTICIA",
                table: "NOTICIACIDADES",
                column: "IDNOTICIA");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIAHISTORICO_IDNOTICIA",
                table: "NOTICIAHISTORICO",
                column: "IDNOTICIA");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIAHISTORICO_IDUSUARIO",
                table: "NOTICIAHISTORICO",
                column: "IDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIATAG_IDNOTICIA",
                table: "NOTICIATAG",
                column: "IDNOTICIA");

            migrationBuilder.CreateIndex(
                name: "IX_NOTICIATAG_IDTAG",
                table: "NOTICIATAG",
                column: "IDTAG");

            migrationBuilder.CreateIndex(
                name: "IX_SUPORTESOLICITACOES_IDCIDADE",
                table: "SUPORTESOLICITACOES",
                column: "IDCIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_SUPORTESOLICITACOES_IDPESSOA",
                table: "SUPORTESOLICITACOES",
                column: "IDPESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_IDPESSOA",
                table: "USUARIO",
                column: "IDPESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOROLE_ROLEID",
                table: "USUARIOROLE",
                column: "ROLEID");

            migrationBuilder.CreateIndex(
                name: "IX_VISUALIZACAO_IDNOTICIA",
                table: "VISUALIZACAO",
                column: "IDNOTICIA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGENDAMENTOHISTORICOS");

            migrationBuilder.DropTable(
                name: "AGENDAMENTOSOLICITACAOHISTORICOS");

            migrationBuilder.DropTable(
                name: "COMENTARIOS");

            migrationBuilder.DropTable(
                name: "CONSULTAATENDIMENTOSAIDA");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOHISTORICOS");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOHOLERITES");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOPONTOREGISTROS");

            migrationBuilder.DropTable(
                name: "NOTICIAAUTORES");

            migrationBuilder.DropTable(
                name: "NOTICIACIDADES");

            migrationBuilder.DropTable(
                name: "NOTICIAHISTORICO");

            migrationBuilder.DropTable(
                name: "NOTICIATAG");

            migrationBuilder.DropTable(
                name: "SUPORTESOLICITACOES");

            migrationBuilder.DropTable(
                name: "USUARIOROLE");

            migrationBuilder.DropTable(
                name: "VISUALIZACAO");

            migrationBuilder.DropTable(
                name: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropTable(
                name: "CONSULTAATENDIMENTO");

            migrationBuilder.DropTable(
                name: "TAGS");

            migrationBuilder.DropTable(
                name: "ROLE");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "NOTICIAS");

            migrationBuilder.DropTable(
                name: "AGENDAMENTOS");

            migrationBuilder.DropTable(
                name: "HOSPITAL");

            migrationBuilder.DropTable(
                name: "MEDICO");

            migrationBuilder.DropTable(
                name: "FUNCIONARIOS");

            migrationBuilder.DropTable(
                name: "CIDADE");

            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "UNIDADEFEDERATIVA");
        }
    }
}
