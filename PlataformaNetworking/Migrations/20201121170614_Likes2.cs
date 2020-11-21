using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class Likes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Usuario_Usuario1Id",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Usuario_Usuario2Id",
                table: "Like");

            migrationBuilder.DropIndex(
                name: "IX_Like_Usuario1Id",
                table: "Like");

            migrationBuilder.DropIndex(
                name: "IX_Like_Usuario2Id",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "Usuario1Id",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "Usuario2Id",
                table: "Like");

            migrationBuilder.RenameColumn(
                name: "IdUsuario2",
                table: "Like",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdUsuario1",
                table: "Like",
                newName: "IdPost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Like",
                newName: "IdUsuario2");

            migrationBuilder.RenameColumn(
                name: "IdPost",
                table: "Like",
                newName: "IdUsuario1");

            migrationBuilder.AddColumn<int>(
                name: "Usuario1Id",
                table: "Like",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Usuario2Id",
                table: "Like",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Like_Usuario1Id",
                table: "Like",
                column: "Usuario1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Like_Usuario2Id",
                table: "Like",
                column: "Usuario2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Usuario_Usuario1Id",
                table: "Like",
                column: "Usuario1Id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Usuario_Usuario2Id",
                table: "Like",
                column: "Usuario2Id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
