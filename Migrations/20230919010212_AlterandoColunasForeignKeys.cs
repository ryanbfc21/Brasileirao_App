using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Brasileirao_App.Migrations
{
    public partial class AlterandoColunasForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_UFs_UFNavigationId",
                table: "Estadios");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Posicoes_PosicaoNavigationId",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Times_TimeNavigationId",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Times_Estadios_EstadioNavigationId",
                table: "Times");

            migrationBuilder.DropIndex(
                name: "IX_Times_EstadioNavigationId",
                table: "Times");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_PosicaoNavigationId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_TimeNavigationId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Estadios_UFNavigationId",
                table: "Estadios");

            migrationBuilder.DropColumn(
                name: "EstadioNavigationId",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "PosicaoNavigationId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "TimeNavigationId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "UFNavigationId",
                table: "Estadios");

            migrationBuilder.CreateIndex(
                name: "IX_Times_IdEstadio",
                table: "Times",
                column: "IdEstadio");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_IdPosicao",
                table: "Jogadores",
                column: "IdPosicao");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_IdTime",
                table: "Jogadores",
                column: "IdTime");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_IdUf",
                table: "Estadios",
                column: "IdUf");

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_UFs_IdUf",
                table: "Estadios",
                column: "IdUf",
                principalTable: "UFs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Posicoes_IdPosicao",
                table: "Jogadores",
                column: "IdPosicao",
                principalTable: "Posicoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Times_IdTime",
                table: "Jogadores",
                column: "IdTime",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Times_Estadios_IdEstadio",
                table: "Times",
                column: "IdEstadio",
                principalTable: "Estadios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_UFs_IdUf",
                table: "Estadios");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Posicoes_IdPosicao",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Times_IdTime",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Times_Estadios_IdEstadio",
                table: "Times");

            migrationBuilder.DropIndex(
                name: "IX_Times_IdEstadio",
                table: "Times");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_IdPosicao",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_IdTime",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Estadios_IdUf",
                table: "Estadios");

            migrationBuilder.AddColumn<int>(
                name: "EstadioNavigationId",
                table: "Times",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PosicaoNavigationId",
                table: "Jogadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeNavigationId",
                table: "Jogadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UFNavigationId",
                table: "Estadios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Times_EstadioNavigationId",
                table: "Times",
                column: "EstadioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_PosicaoNavigationId",
                table: "Jogadores",
                column: "PosicaoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_TimeNavigationId",
                table: "Jogadores",
                column: "TimeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_UFNavigationId",
                table: "Estadios",
                column: "UFNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_UFs_UFNavigationId",
                table: "Estadios",
                column: "UFNavigationId",
                principalTable: "UFs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Posicoes_PosicaoNavigationId",
                table: "Jogadores",
                column: "PosicaoNavigationId",
                principalTable: "Posicoes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Times_TimeNavigationId",
                table: "Jogadores",
                column: "TimeNavigationId",
                principalTable: "Times",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Times_Estadios_EstadioNavigationId",
                table: "Times",
                column: "EstadioNavigationId",
                principalTable: "Estadios",
                principalColumn: "Id");
        }
    }
}
