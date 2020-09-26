using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class funciona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Usuario_Usario1Id",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Usuario_Usario2Id",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Semestre",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Usario2Id",
                table: "Like",
                newName: "Usuario2Id");

            migrationBuilder.RenameColumn(
                name: "Usario1Id",
                table: "Like",
                newName: "Usuario1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Like_Usario2Id",
                table: "Like",
                newName: "IX_Like_Usuario2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Like_Usario1Id",
                table: "Like",
                newName: "IX_Like_Usuario1Id");

            migrationBuilder.AlterColumn<int>(
                name: "AnoIngresso",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Curriculo",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Habilidades",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Usuario",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Usuario_Usuario1Id",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Usuario_Usuario2Id",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "Curriculo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Habilidades",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Usuario2Id",
                table: "Like",
                newName: "Usario2Id");

            migrationBuilder.RenameColumn(
                name: "Usuario1Id",
                table: "Like",
                newName: "Usario1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Like_Usuario2Id",
                table: "Like",
                newName: "IX_Like_Usario2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Like_Usuario1Id",
                table: "Like",
                newName: "IX_Like_Usario1Id");

            migrationBuilder.AlterColumn<int>(
                name: "AnoIngresso",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Semestre",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Usuario_Usario1Id",
                table: "Like",
                column: "Usario1Id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Usuario_Usario2Id",
                table: "Like",
                column: "Usario2Id",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
