using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class candidato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Vaga_VagaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_VagaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdVaga = table.Column<int>(nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.AddColumn<int>(
                name: "VagaId",
                table: "Usuario",
                nullable: true);

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
    }
}
