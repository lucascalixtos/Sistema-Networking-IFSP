using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class empresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ramo",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Ramo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Usuario");
        }
    }
}
