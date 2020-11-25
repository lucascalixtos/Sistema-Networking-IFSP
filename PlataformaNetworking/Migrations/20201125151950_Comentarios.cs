using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class Comentarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Usuario_UsuarioId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Usuario_UsuarioPostId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_PostId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_UsuarioId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "UsuarioPostId",
                table: "Comment",
                newName: "PostModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UsuarioPostId",
                table: "Comment",
                newName: "IX_Comment_PostModelId");

            migrationBuilder.AddColumn<int>(
                name: "IdPost",
                table: "Comment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostModelId",
                table: "Comment",
                column: "PostModelId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostModelId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "IdPost",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "PostModelId",
                table: "Comment",
                newName: "UsuarioPostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostModelId",
                table: "Comment",
                newName: "IX_Comment_UsuarioPostId");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Comment",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UsuarioId",
                table: "Comment",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Usuario_UsuarioId",
                table: "Comment",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Usuario_UsuarioPostId",
                table: "Comment",
                column: "UsuarioPostId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
