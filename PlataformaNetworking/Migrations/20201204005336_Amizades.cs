using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class Amizades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amizades",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amizades",
                table: "Usuario");
        }
    }
}
