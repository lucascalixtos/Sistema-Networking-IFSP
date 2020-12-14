using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class curriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Curriculo",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "CurriculoId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Curriculo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Dados = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CurriculoId",
                table: "Usuario",
                column: "CurriculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Curriculo_CurriculoId",
                table: "Usuario",
                column: "CurriculoId",
                principalTable: "Curriculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Curriculo_CurriculoId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Curriculo");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CurriculoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CurriculoId",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "Curriculo",
                table: "Usuario",
                nullable: true);
        }
    }
}
