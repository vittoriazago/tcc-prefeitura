using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Prefeitura.Geral.Persistencia.Migrations
{
    public partial class NoticiaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DATACADASTRO",
                table: "NOTICIAS",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AGENDAMENTOS",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DATAHORADISPONIVELFINAL", "DATAHORADISPONIVELINICIAL" },
                values: new object[] { new DateTime(2020, 10, 22, 3, 1, 13, 804, DateTimeKind.Local).AddTicks(5946), new DateTime(2020, 10, 22, 0, 1, 13, 802, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "AGENDAMENTOS",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DATAHORADISPONIVELFINAL", "DATAHORADISPONIVELINICIAL" },
                values: new object[] { new DateTime(2020, 10, 22, 3, 1, 13, 805, DateTimeKind.Local).AddTicks(1795), new DateTime(2020, 10, 22, 0, 1, 13, 805, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "PESSOA",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATANASCIMENTO",
                value: new DateTime(2000, 10, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ROLE",
                keyColumn: "ID",
                keyValue: 1,
                column: "CONCURRENCYSTAMP",
                value: "5cc9a6da-1136-4e8f-8de7-1deb1e6ebe26");

            migrationBuilder.UpdateData(
                table: "USUARIO",
                keyColumn: "ID",
                keyValue: 1,
                column: "DATACADASTRO",
                value: new DateTime(2020, 10, 22, 0, 1, 13, 809, DateTimeKind.Local).AddTicks(3165));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DATACADASTRO",
                table: "NOTICIAS");

            migrationBuilder.UpdateData(
                table: "AGENDAMENTOS",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DATAHORADISPONIVELFINAL", "DATAHORADISPONIVELINICIAL" },
                values: new object[] { new DateTime(2020, 10, 16, 23, 18, 10, 263, DateTimeKind.Local).AddTicks(234), new DateTime(2020, 10, 16, 20, 18, 10, 261, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "AGENDAMENTOS",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DATAHORADISPONIVELFINAL", "DATAHORADISPONIVELINICIAL" },
                values: new object[] { new DateTime(2020, 10, 16, 23, 18, 10, 264, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 10, 16, 20, 18, 10, 264, DateTimeKind.Local).AddTicks(2443) });

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
    }
}
