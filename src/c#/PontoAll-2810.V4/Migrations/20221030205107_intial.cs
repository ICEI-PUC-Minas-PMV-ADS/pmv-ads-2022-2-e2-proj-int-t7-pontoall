using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace PontoAll_2810.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BancoHoras",
                columns: table => new
                {
                    IdBancoHoras = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<string>(nullable: true),
                    Ocorrencias = table.Column<string>(nullable: true),
                    Notificacoes = table.Column<string>(nullable: true),
                    SaldoBancoHoras = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoHoras", x => x.IdBancoHoras);
                });

            migrationBuilder.CreateTable(
                name: "RegistroPonto",
                columns: table => new
                {
                    IdRegistroPonto = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DataRegistro = table.Column<string>(nullable: false),
                    HoraRegistro = table.Column<string>(nullable: true),
                    LocalizacaoRegistro = table.Column<string>(nullable: true),
                    SomaHora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroPonto", x => x.IdRegistroPonto);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Usu_Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: true),
                    Jornada = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<string>(nullable: true),
                    Admissao = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: false),
                    Previlegios = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: false),
                    Salario = table.Column<string>(nullable: true),
                    Desligamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Usu_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BancoHoras");

            migrationBuilder.DropTable(
                name: "RegistroPonto");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
