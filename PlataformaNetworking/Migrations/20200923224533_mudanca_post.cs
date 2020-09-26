using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class mudanca_post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoUsuario",
                table: "Post",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Post",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoUsuario",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Post");
        }
    }
}
