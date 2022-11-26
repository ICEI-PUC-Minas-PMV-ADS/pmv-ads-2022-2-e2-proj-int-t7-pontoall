using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace PontoAll_2810.Migrations
{
    public partial class incial : Migration
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
                name: "Colaborador",
                columns: table => new
                {
                    Usu_Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: true),
                    CargaHoraria = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<string>(nullable: true),
                    Admissao = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: false),
                    Matricula = table.Column<string>(nullable: true),
                    Funcao = table.Column<int>(nullable: false),
                    Salario = table.Column<string>(nullable: true),
                    Desligamento = table.Column<string>(nullable: true),
                    ColaboradorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Usu_Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Usu_Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Perfil = table.Column<int>(nullable: false),
                    SomaHora = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroPonto", x => x.IdRegistroPonto);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Perfil = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    MatriculaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Colaborador_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Colaborador",
                        principalColumn: "Usu_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Colaborador_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Colaborador",
                        principalColumn: "Usu_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_ColaboradorId",
                table: "Colaborador",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MatriculaId",
                table: "User",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UsuarioId",
                table: "User",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BancoHoras");

            migrationBuilder.DropTable(
                name: "RegistroPonto");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Colaborador");
        }
    }
}
