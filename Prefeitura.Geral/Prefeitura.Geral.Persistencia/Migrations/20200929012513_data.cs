using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Prefeitura.Geral.Persistencia.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_CIDADE_IDCIDADE",
                table: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_PESSOA_IDPESSOA",
                table: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_AGENDAMENTOSOLICITACAO_IDAGENDAMENTOSOLICITACAO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_CIDADE_UNIDADEFEDERATIVA_IDUNIDADEFEDERATIVA",
                table: "CIDADE");

            migrationBuilder.DropForeignKey(
                name: "FK_COMENTARIOS_NOTICIAS_IDNOTICIA",
                table: "COMENTARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTO_HOSPITAL_IDHOSPITAL",
                table: "CONSULTAATENDIMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTO_MEDICO_IDMEDICO",
                table: "CONSULTAATENDIMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTO_PESSOA_IDPESSOA",
                table: "CONSULTAATENDIMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTOSAIDA_CONSULTAATENDIMENTO_IDCONSULTAATENDIMENTO",
                table: "CONSULTAATENDIMENTOSAIDA");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_USUARIO_IDUSUARIO",
                table: "FUNCIONARIOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOHOLERITES_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHOLERITES");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOPONTOREGISTROS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOPONTOREGISTROS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOS_CIDADE_IDCIDADE",
                table: "FUNCIONARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOS_PESSOA_IDPESSOA",
                table: "FUNCIONARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_HOSPITAL_CIDADE_IDCIDADE",
                table: "HOSPITAL");

            migrationBuilder.DropForeignKey(
                name: "FK_MEDICO_FUNCIONARIOS_IDFUNCIONARIO",
                table: "MEDICO");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAAUTORES_PESSOA_IDAUTOR",
                table: "NOTICIAAUTORES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAAUTORES_NOTICIAS_IDNOTICIA",
                table: "NOTICIAAUTORES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIACIDADES_CIDADE_IDCIDADE",
                table: "NOTICIACIDADES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIACIDADES_NOTICIAS_IDNOTICIA",
                table: "NOTICIACIDADES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAHISTORICO_NOTICIAS_IDNOTICIA",
                table: "NOTICIAHISTORICO");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAHISTORICO_USUARIO_IDUSUARIO",
                table: "NOTICIAHISTORICO");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIATAG_NOTICIAS_IDNOTICIA",
                table: "NOTICIATAG");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIATAG_TAGS_IDTAG",
                table: "NOTICIATAG");

            migrationBuilder.DropForeignKey(
                name: "FK_SUPORTESOLICITACOES_CIDADE_IDCIDADE",
                table: "SUPORTESOLICITACOES");

            migrationBuilder.DropForeignKey(
                name: "FK_SUPORTESOLICITACOES_PESSOA_IDPESSOA",
                table: "SUPORTESOLICITACOES");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIO_PESSOA_IDPESSOA",
                table: "USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOROLE_ROLE_ROLEID",
                table: "USUARIOROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOROLE_USUARIO_USERID",
                table: "USUARIOROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_VISUALIZACAO_NOTICIAS_IDNOTICIA",
                table: "VISUALIZACAO");

            migrationBuilder.DropColumn(
                name: "IDPESSOA",
                table: "USUARIOROLE");

            migrationBuilder.InsertData(
                table: "PESSOA",
                columns: new[] { "ID", "DATANASCIMENTO", "DOCUMENTO", "NOME" },
                values: new object[] { 1, new DateTime(2000, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "43553936827", "Admin" });

            migrationBuilder.InsertData(
                table: "ROLE",
                columns: new[] { "ID", "CONCURRENCYSTAMP", "NAME", "NORMALIZEDNAME" },
                values: new object[] { 1, "1e36ac70-e7e2-4b88-aa53-c996c94307d6", "admin", "ADMIN" });

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
                values: new object[] { 1, "BAURU", 2 });

            migrationBuilder.InsertData(
                table: "CIDADE",
                columns: new[] { "ID", "DESCRICAO", "IDUNIDADEFEDERATIVA" },
                values: new object[] { 2, "BAURU", 2 });

            migrationBuilder.InsertData(
                table: "USUARIO",
                columns: new[] { "ID", "ACCESSFAILEDCOUNT", "ATIVO", "CONCURRENCYSTAMP", "DATACADASTRO", "EMAIL", "EMAILCONFIRMED", "IDPESSOA", "LOCKOUTENABLED", "LOCKOUTEND", "NORMALIZEDEMAIL", "NORMALIZEDUSERNAME", "PASSWORDHASH", "PHONENUMBER", "PHONENUMBERCONFIRMED", "SECURITYSTAMP", "TWOFACTORENABLED", "USERNAME" },
                values: new object[] { 1, 0, true, "c8554266-b401-4519-9aeb-a9283053fc58", new DateTime(2020, 9, 28, 22, 25, 11, 909, DateTimeKind.Local).AddTicks(9937), "myemail@myemail.com", true, 1, false, null, "MYEMAIL@MYEMAIL.COM", "MYEMAIL@MYEMAIL.COM", "AQABBAEABCcQAABAEBhd37krE/TyMklt3SIf2Q3ITj/dunHYr7O5Z9UB0R1+dpDbcrHWuTBr8Uh5WR+JrQ==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "myemail@myemail.com" });

            migrationBuilder.InsertData(
                table: "USUARIOROLE",
                columns: new[] { "USERID", "ROLEID" },
                values: new object[] { 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOHISTORICOS",
                column: "IDAGENDAMENTO",
                principalTable: "AGENDAMENTOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOHISTORICOS",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDAGENDAMENTO",
                principalTable: "AGENDAMENTOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_CIDADE_IDCIDADE",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_PESSOA_IDPESSOA",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_AGENDAMENTOSOLICITACAO_IDAGENDAMENTOSOLICITACAO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS",
                column: "IDAGENDAMENTOSOLICITACAO",
                principalTable: "AGENDAMENTOSOLICITACAO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CIDADE_UNIDADEFEDERATIVA_IDUNIDADEFEDERATIVA",
                table: "CIDADE",
                column: "IDUNIDADEFEDERATIVA",
                principalTable: "UNIDADEFEDERATIVA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_COMENTARIOS_NOTICIAS_IDNOTICIA",
                table: "COMENTARIOS",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTO_HOSPITAL_IDHOSPITAL",
                table: "CONSULTAATENDIMENTO",
                column: "IDHOSPITAL",
                principalTable: "HOSPITAL",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTO_MEDICO_IDMEDICO",
                table: "CONSULTAATENDIMENTO",
                column: "IDMEDICO",
                principalTable: "MEDICO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTO_PESSOA_IDPESSOA",
                table: "CONSULTAATENDIMENTO",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTOSAIDA_CONSULTAATENDIMENTO_IDCONSULTAATENDIMENTO",
                table: "CONSULTAATENDIMENTOSAIDA",
                column: "IDCONSULTAATENDIMENTO",
                principalTable: "CONSULTAATENDIMENTO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHISTORICOS",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_USUARIO_IDUSUARIO",
                table: "FUNCIONARIOHISTORICOS",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOHOLERITES_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHOLERITES",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOPONTOREGISTROS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOPONTOREGISTROS",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOS_CIDADE_IDCIDADE",
                table: "FUNCIONARIOS",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOS_PESSOA_IDPESSOA",
                table: "FUNCIONARIOS",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOSPITAL_CIDADE_IDCIDADE",
                table: "HOSPITAL",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MEDICO_FUNCIONARIOS_IDFUNCIONARIO",
                table: "MEDICO",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAAUTORES_PESSOA_IDAUTOR",
                table: "NOTICIAAUTORES",
                column: "IDAUTOR",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAAUTORES_NOTICIAS_IDNOTICIA",
                table: "NOTICIAAUTORES",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIACIDADES_CIDADE_IDCIDADE",
                table: "NOTICIACIDADES",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIACIDADES_NOTICIAS_IDNOTICIA",
                table: "NOTICIACIDADES",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAHISTORICO_NOTICIAS_IDNOTICIA",
                table: "NOTICIAHISTORICO",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAHISTORICO_USUARIO_IDUSUARIO",
                table: "NOTICIAHISTORICO",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIATAG_NOTICIAS_IDNOTICIA",
                table: "NOTICIATAG",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIATAG_TAGS_IDTAG",
                table: "NOTICIATAG",
                column: "IDTAG",
                principalTable: "TAGS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SUPORTESOLICITACOES_CIDADE_IDCIDADE",
                table: "SUPORTESOLICITACOES",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SUPORTESOLICITACOES_PESSOA_IDPESSOA",
                table: "SUPORTESOLICITACOES",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIO_PESSOA_IDPESSOA",
                table: "USUARIO",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOROLE_ROLE_ROLEID",
                table: "USUARIOROLE",
                column: "ROLEID",
                principalTable: "ROLE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOROLE_USUARIO_USERID",
                table: "USUARIOROLE",
                column: "USERID",
                principalTable: "USUARIO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VISUALIZACAO_NOTICIAS_IDNOTICIA",
                table: "VISUALIZACAO",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_CIDADE_IDCIDADE",
                table: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_PESSOA_IDPESSOA",
                table: "AGENDAMENTOSOLICITACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_AGENDAMENTOSOLICITACAO_IDAGENDAMENTOSOLICITACAO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_CIDADE_UNIDADEFEDERATIVA_IDUNIDADEFEDERATIVA",
                table: "CIDADE");

            migrationBuilder.DropForeignKey(
                name: "FK_COMENTARIOS_NOTICIAS_IDNOTICIA",
                table: "COMENTARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTO_HOSPITAL_IDHOSPITAL",
                table: "CONSULTAATENDIMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTO_MEDICO_IDMEDICO",
                table: "CONSULTAATENDIMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTO_PESSOA_IDPESSOA",
                table: "CONSULTAATENDIMENTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CONSULTAATENDIMENTOSAIDA_CONSULTAATENDIMENTO_IDCONSULTAATENDIMENTO",
                table: "CONSULTAATENDIMENTOSAIDA");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_USUARIO_IDUSUARIO",
                table: "FUNCIONARIOHISTORICOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOHOLERITES_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHOLERITES");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOPONTOREGISTROS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOPONTOREGISTROS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOS_CIDADE_IDCIDADE",
                table: "FUNCIONARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_FUNCIONARIOS_PESSOA_IDPESSOA",
                table: "FUNCIONARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_HOSPITAL_CIDADE_IDCIDADE",
                table: "HOSPITAL");

            migrationBuilder.DropForeignKey(
                name: "FK_MEDICO_FUNCIONARIOS_IDFUNCIONARIO",
                table: "MEDICO");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAAUTORES_PESSOA_IDAUTOR",
                table: "NOTICIAAUTORES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAAUTORES_NOTICIAS_IDNOTICIA",
                table: "NOTICIAAUTORES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIACIDADES_CIDADE_IDCIDADE",
                table: "NOTICIACIDADES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIACIDADES_NOTICIAS_IDNOTICIA",
                table: "NOTICIACIDADES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAHISTORICO_NOTICIAS_IDNOTICIA",
                table: "NOTICIAHISTORICO");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIAHISTORICO_USUARIO_IDUSUARIO",
                table: "NOTICIAHISTORICO");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIATAG_NOTICIAS_IDNOTICIA",
                table: "NOTICIATAG");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTICIATAG_TAGS_IDTAG",
                table: "NOTICIATAG");

            migrationBuilder.DropForeignKey(
                name: "FK_SUPORTESOLICITACOES_CIDADE_IDCIDADE",
                table: "SUPORTESOLICITACOES");

            migrationBuilder.DropForeignKey(
                name: "FK_SUPORTESOLICITACOES_PESSOA_IDPESSOA",
                table: "SUPORTESOLICITACOES");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIO_PESSOA_IDPESSOA",
                table: "USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOROLE_ROLE_ROLEID",
                table: "USUARIOROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIOROLE_USUARIO_USERID",
                table: "USUARIOROLE");

            migrationBuilder.DropForeignKey(
                name: "FK_VISUALIZACAO_NOTICIAS_IDNOTICIA",
                table: "VISUALIZACAO");

            migrationBuilder.DeleteData(
                table: "CIDADE",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CIDADE",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UNIDADEFEDERATIVA",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "USUARIOROLE",
                keyColumns: new[] { "USERID", "ROLEID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ROLE",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UNIDADEFEDERATIVA",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "USUARIO",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PESSOA",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "IDPESSOA",
                table: "USUARIOROLE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOHISTORICOS",
                column: "IDAGENDAMENTO",
                principalTable: "AGENDAMENTOS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOHISTORICOS",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_AGENDAMENTOS_IDAGENDAMENTO",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDAGENDAMENTO",
                principalTable: "AGENDAMENTOS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_CIDADE_IDCIDADE",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAO_PESSOA_IDPESSOA",
                table: "AGENDAMENTOSOLICITACAO",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_AGENDAMENTOSOLICITACAO_IDAGENDAMENTOSOLICITACAO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS",
                column: "IDAGENDAMENTOSOLICITACAO",
                principalTable: "AGENDAMENTOSOLICITACAO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AGENDAMENTOSOLICITACAOHISTORICOS_USUARIO_IDUSUARIO",
                table: "AGENDAMENTOSOLICITACAOHISTORICOS",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CIDADE_UNIDADEFEDERATIVA_IDUNIDADEFEDERATIVA",
                table: "CIDADE",
                column: "IDUNIDADEFEDERATIVA",
                principalTable: "UNIDADEFEDERATIVA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_COMENTARIOS_NOTICIAS_IDNOTICIA",
                table: "COMENTARIOS",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTO_HOSPITAL_IDHOSPITAL",
                table: "CONSULTAATENDIMENTO",
                column: "IDHOSPITAL",
                principalTable: "HOSPITAL",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTO_MEDICO_IDMEDICO",
                table: "CONSULTAATENDIMENTO",
                column: "IDMEDICO",
                principalTable: "MEDICO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTO_PESSOA_IDPESSOA",
                table: "CONSULTAATENDIMENTO",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CONSULTAATENDIMENTOSAIDA_CONSULTAATENDIMENTO_IDCONSULTAATENDIMENTO",
                table: "CONSULTAATENDIMENTOSAIDA",
                column: "IDCONSULTAATENDIMENTO",
                principalTable: "CONSULTAATENDIMENTO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHISTORICOS",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOHISTORICOS_USUARIO_IDUSUARIO",
                table: "FUNCIONARIOHISTORICOS",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOHOLERITES_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOHOLERITES",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOPONTOREGISTROS_FUNCIONARIOS_IDFUNCIONARIO",
                table: "FUNCIONARIOPONTOREGISTROS",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOS_CIDADE_IDCIDADE",
                table: "FUNCIONARIOS",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FUNCIONARIOS_PESSOA_IDPESSOA",
                table: "FUNCIONARIOS",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_HOSPITAL_CIDADE_IDCIDADE",
                table: "HOSPITAL",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MEDICO_FUNCIONARIOS_IDFUNCIONARIO",
                table: "MEDICO",
                column: "IDFUNCIONARIO",
                principalTable: "FUNCIONARIOS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAAUTORES_PESSOA_IDAUTOR",
                table: "NOTICIAAUTORES",
                column: "IDAUTOR",
                principalTable: "PESSOA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAAUTORES_NOTICIAS_IDNOTICIA",
                table: "NOTICIAAUTORES",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIACIDADES_CIDADE_IDCIDADE",
                table: "NOTICIACIDADES",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIACIDADES_NOTICIAS_IDNOTICIA",
                table: "NOTICIACIDADES",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAHISTORICO_NOTICIAS_IDNOTICIA",
                table: "NOTICIAHISTORICO",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIAHISTORICO_USUARIO_IDUSUARIO",
                table: "NOTICIAHISTORICO",
                column: "IDUSUARIO",
                principalTable: "USUARIO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIATAG_NOTICIAS_IDNOTICIA",
                table: "NOTICIATAG",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_NOTICIATAG_TAGS_IDTAG",
                table: "NOTICIATAG",
                column: "IDTAG",
                principalTable: "TAGS",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SUPORTESOLICITACOES_CIDADE_IDCIDADE",
                table: "SUPORTESOLICITACOES",
                column: "IDCIDADE",
                principalTable: "CIDADE",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SUPORTESOLICITACOES_PESSOA_IDPESSOA",
                table: "SUPORTESOLICITACOES",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIO_PESSOA_IDPESSOA",
                table: "USUARIO",
                column: "IDPESSOA",
                principalTable: "PESSOA",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOROLE_ROLE_ROLEID",
                table: "USUARIOROLE",
                column: "ROLEID",
                principalTable: "ROLE",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIOROLE_USUARIO_USERID",
                table: "USUARIOROLE",
                column: "USERID",
                principalTable: "USUARIO",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_VISUALIZACAO_NOTICIAS_IDNOTICIA",
                table: "VISUALIZACAO",
                column: "IDNOTICIA",
                principalTable: "NOTICIAS",
                principalColumn: "ID");
        }
    }
}
