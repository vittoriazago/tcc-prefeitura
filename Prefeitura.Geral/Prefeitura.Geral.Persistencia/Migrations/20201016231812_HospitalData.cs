using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prefeitura.Persistencia.Migrations
{
    public partial class HospitalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AGENDAMENTOS",
                columns: new[] { "ID", "DATAHORADISPONIVELFINAL", "DATAHORADISPONIVELINICIAL", "DESCRICAO" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 16, 23, 18, 10, 263, DateTimeKind.Local).AddTicks(234), new DateTime(2020, 10, 16, 20, 18, 10, 261, DateTimeKind.Local).AddTicks(5349), "Solicitar carteira de trabalho" },
                    { 2, new DateTime(2020, 10, 16, 23, 18, 10, 264, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 10, 16, 20, 18, 10, 264, DateTimeKind.Local).AddTicks(2443), "Minha casa minha vida" }
                });

            migrationBuilder.InsertData(
                table: "HOSPITAL",
                columns: new[] { "ID", "IDCIDADE", "NOMEHOSPITAL" },
                values: new object[,]
                {
                    { 1, 1, "Hospital Saúde SP" },
                    { 2, 1, "Hospital São José" }
                });

            migrationBuilder.UpdateData(
                table: "PESSOA",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATANASCIMENTO",
                value: new DateTime(2000, 10, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ROLE",
                keyColumn: "ID",
                keyValue: 1,
                column: "CONCURRENCYSTAMP",
                value: "340a51a7-6e30-41ba-a01a-162209481501");

            migrationBuilder.UpdateData(
                table: "USUARIO",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATACADASTRO",
                value: new DateTime(2020, 10, 16, 20, 18, 10, 268, DateTimeKind.Local).AddTicks(7483));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AGENDAMENTOS",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AGENDAMENTOS",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HOSPITAL",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HOSPITAL",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "PESSOA",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATANASCIMENTO",
                value: new DateTime(2000, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

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
    }
}
