using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Brasileirao_App.Migrations
{
    public partial class CriandoTabelasIniciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sigla = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdUf = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    UFNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadios_UFs_UFNavigationId",
                        column: x => x.UFNavigationId,
                        principalTable: "UFs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstadio = table.Column<int>(type: "int", nullable: false),
                    EstadioNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Times_Estadios_EstadioNavigationId",
                        column: x => x.EstadioNavigationId,
                        principalTable: "Estadios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nr_Camisa = table.Column<int>(type: "int", nullable: false),
                    IdTime = table.Column<int>(type: "int", nullable: false),
                    IdPosicao = table.Column<int>(type: "int", nullable: false),
                    TimeNavigationId = table.Column<int>(type: "int", nullable: true),
                    PosicaoNavigationId = table.Column<int>(type: "int", nullable: true),
                    Lesionado = table.Column<bool>(type: "bit", nullable: false),
                    Suspenso = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogadores_Posicoes_PosicaoNavigationId",
                        column: x => x.PosicaoNavigationId,
                        principalTable: "Posicoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jogadores_Times_TimeNavigationId",
                        column: x => x.TimeNavigationId,
                        principalTable: "Times",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_UFNavigationId",
                table: "Estadios",
                column: "UFNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_PosicaoNavigationId",
                table: "Jogadores",
                column: "PosicaoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_TimeNavigationId",
                table: "Jogadores",
                column: "TimeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Times_EstadioNavigationId",
                table: "Times",
                column: "EstadioNavigationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogadores");

            migrationBuilder.DropTable(
                name: "Posicoes");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "UFs");
        }
    }
}
