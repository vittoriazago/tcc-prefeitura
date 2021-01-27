using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Prefeitura.Geral.Persistencia.Migrations
{
    public partial class dataFixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CIDADE",
                keyColumn: "ID",
                keyValue: 1,
                column: "IDUNIDADEFEDERATIVA",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CIDADE",
                keyColumn: "ID",
                keyValue: 2,
                column: "DESCRICAO",
                value: "BELO HORIZONTE");

            migrationBuilder.UpdateData(
                table: "ROLE",
                keyColumn: "ID",
                keyValue: 1,
                column: "CONCURRENCYSTAMP",
                value: "d6d83ab4-fa10-4eaf-a422-3076a0c7f5fb");

            migrationBuilder.UpdateData(
                table: "USUARIO",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATACADASTRO",
                value: new DateTime(2020, 9, 28, 22, 31, 11, 264, DateTimeKind.Local).AddTicks(4755));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CIDADE",
                keyColumn: "ID",
                keyValue: 1,
                column: "IDUNIDADEFEDERATIVA",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CIDADE",
                keyColumn: "ID",
                keyValue: 2,
                column: "DESCRICAO",
                value: "BAURU");

            migrationBuilder.UpdateData(
                table: "ROLE",
                keyColumn: "ID",
                keyValue: 1,
                column: "CONCURRENCYSTAMP",
                value: "1e36ac70-e7e2-4b88-aa53-c996c94307d6");

            migrationBuilder.UpdateData(
                table: "USUARIO",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATACADASTRO",
                value: new DateTime(2020, 9, 28, 22, 25, 11, 909, DateTimeKind.Local).AddTicks(9937));
        }
    }
}
