using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prefeitura.ServicosCidadao.Persistencia.Migrations
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
                    CONTEUDOHTML = table.Column<string>(nullable: true),
                    DATACADASTRO = table.Column<DateTime>(nullable: false)
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NOTICIAAUTORES_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NOTICIATAG_TAGS_IDTAG",
                        column: x => x.IDTAG,
                        principalTable: "TAGS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOHISTORICOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NOTICIAHISTORICO_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOROLE",
                columns: table => new
                {
                    USERID = table.Column<int>(nullable: false),
                    ROLEID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOROLE", x => new { x.USERID, x.ROLEID });
                    table.ForeignKey(
                        name: "FK_USUARIOROLE_ROLE_ROLEID",
                        column: x => x.ROLEID,
                        principalTable: "ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USUARIOROLE_USUARIO_USERID",
                        column: x => x.USERID,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAO_CIDADE_IDCIDADE",
                        column: x => x.IDCIDADE,
                        principalTable: "CIDADE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAO_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOS_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NOTICIACIDADES_NOTICIAS_IDNOTICIA",
                        column: x => x.IDNOTICIA,
                        principalTable: "NOTICIAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SUPORTESOLICITACOES_PESSOA_IDPESSOA",
                        column: x => x.IDPESSOA,
                        principalTable: "PESSOA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIOHISTORICOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AGENDAMENTOS",
                columns: new[] { "ID", "DATAHORADISPONIVELFINAL", "DATAHORADISPONIVELINICIAL", "DESCRICAO" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 27, 3, 29, 40, 917, DateTimeKind.Local).AddTicks(8976), new DateTime(2021, 1, 27, 0, 29, 40, 916, DateTimeKind.Local).AddTicks(4616), "Solicitar carteira de trabalho" },
                    { 2, new DateTime(2021, 1, 27, 3, 29, 40, 918, DateTimeKind.Local).AddTicks(2878), new DateTime(2021, 1, 27, 0, 29, 40, 918, DateTimeKind.Local).AddTicks(2870), "Minha casa minha vida" }
                });

            migrationBuilder.InsertData(
                table: "PESSOA",
                columns: new[] { "ID", "DATANASCIMENTO", "DOCUMENTO", "NOME" },
                values: new object[] { 1, new DateTime(2001, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "43553936827", "Admin" });

            migrationBuilder.InsertData(
                table: "ROLE",
                columns: new[] { "ID", "CONCURRENCYSTAMP", "NAME", "NORMALIZEDNAME" },
                values: new object[] { 1, "b0615f0d-aa19-4a8d-916e-1f17d9f29547", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "UNIDADEFEDERATIVA",
                columns: new[] { "ID", "SIGLA" },
                values: new object[,]
                {
                    { 1, "MG" },
                    { 2, "SP" }
                });

            migrationBuilder.InsertData(
                table: "CIDADE",
                columns: new[] { "ID", "DESCRICAO", "IDUNIDADEFEDERATIVA" },
                values: new object[] { 1, "BAURU", 1 });

            migrationBuilder.InsertData(
                table: "CIDADE",
                columns: new[] { "ID", "DESCRICAO", "IDUNIDADEFEDERATIVA" },
                values: new object[] { 2, "BELO HORIZONTE", 2 });

            migrationBuilder.InsertData(
                table: "USUARIO",
                columns: new[] { "ID", "ACCESSFAILEDCOUNT", "ATIVO", "CONCURRENCYSTAMP", "DATACADASTRO", "EMAIL", "EMAILCONFIRMED", "IDPESSOA", "LOCKOUTENABLED", "LOCKOUTEND", "NORMALIZEDEMAIL", "NORMALIZEDUSERNAME", "PASSWORDHASH", "PHONENUMBER", "PHONENUMBERCONFIRMED", "SECURITYSTAMP", "TWOFACTORENABLED", "USERNAME" },
                values: new object[] { 1, 0, true, "c8554266-b401-4519-9aeb-a9283053fc58", new DateTime(2021, 1, 27, 0, 29, 40, 920, DateTimeKind.Local).AddTicks(903), "myemail@myemail.com", true, 1, false, null, "MYEMAIL@MYEMAIL.COM", "MYEMAIL@MYEMAIL.COM", "AQABBAEABCcQAABAEBhd37krE/TyMklt3SIf2Q3ITj/dunHYr7O5Z9UB0R1+dpDbcrHWuTBr8Uh5WR+JrQ==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "myemail@myemail.com" });

            migrationBuilder.InsertData(
                table: "USUARIOROLE",
                columns: new[] { "USERID", "ROLEID" },
                values: new object[] { 1, 1 });

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
                name: "FUNCIONARIOS");

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
                name: "CIDADE");

            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "UNIDADEFEDERATIVA");
        }
    }
}
