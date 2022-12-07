using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PontoAll_2810.Migrations
{
    public partial class inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "BancoHoras");

            migrationBuilder.DropColumn(
                name: "Notificacoes",
                table: "BancoHoras");

            migrationBuilder.DropColumn(
                name: "Ocorrencias",
                table: "BancoHoras");

            migrationBuilder.DropColumn(
                name: "SaldoBancoHoras",
                table: "BancoHoras");

            migrationBuilder.AlterColumn<string>(
                name: "DataCadastro",
                table: "Colaborador",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CargaHoraria",
                table: "Colaborador",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "BancoHoras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HoraEntrada",
                table: "BancoHoras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoraSaida",
                table: "BancoHoras",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BancoHoras",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "BancoHoras");

            migrationBuilder.DropColumn(
                name: "HoraEntrada",
                table: "BancoHoras");

            migrationBuilder.DropColumn(
                name: "HoraSaida",
                table: "BancoHoras");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BancoHoras");

            migrationBuilder.AlterColumn<string>(
                name: "DataCadastro",
                table: "Colaborador",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CargaHoraria",
                table: "Colaborador",
                type: "text",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Colaborador",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "BancoHoras",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notificacoes",
                table: "BancoHoras",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ocorrencias",
                table: "BancoHoras",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaldoBancoHoras",
                table: "BancoHoras",
                type: "text",
                nullable: true);
        }
    }
}
