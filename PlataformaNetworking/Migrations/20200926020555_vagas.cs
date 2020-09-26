using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class vagas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VagaId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(nullable: true),
                    Conteudo = table.Column<string>(nullable: true),
                    DataPostagem = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_VagaId",
                table: "Usuario",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Vaga_VagaId",
                table: "Usuario",
                column: "VagaId",
                principalTable: "Vaga",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Vaga_VagaId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Vaga");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_VagaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Usuario");
        }
    }
}
