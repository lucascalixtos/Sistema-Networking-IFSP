using Microsoft.EntityFrameworkCore.Migrations;

namespace CadernoDigitalColaborativo.Migrations
{
    public partial class coluna_faltando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UploadPictureUrl",
                table: "Usuario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadPictureUrl",
                table: "Usuario");
        }
    }
}
