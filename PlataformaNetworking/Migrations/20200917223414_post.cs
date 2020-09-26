using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadPictureUrl",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "Dislike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario1 = table.Column<int>(nullable: false),
                    Usario1Id = table.Column<int>(nullable: true),
                    IdUsuario2 = table.Column<int>(nullable: false),
                    Usario2Id = table.Column<int>(nullable: true),
                    DislikedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dislike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dislike_Usuario_Usario1Id",
                        column: x => x.Usario1Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dislike_Usuario_Usario2Id",
                        column: x => x.Usario2Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario = table.Column<int>(nullable: false),
                    UsuarioPostId = table.Column<int>(nullable: true),
                    PostTime = table.Column<DateTime>(nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    TextoPost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Usuario_UsuarioPostId",
                        column: x => x.UsuarioPostId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentTime = table.Column<DateTime>(nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    CommentText = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: true),
                    UsuarioPostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Usuario_UsuarioPostId",
                        column: x => x.UsuarioPostId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdUsuario1 = table.Column<int>(nullable: false),
                    Usario1Id = table.Column<int>(nullable: true),
                    IdUsuario2 = table.Column<int>(nullable: false),
                    Usario2Id = table.Column<int>(nullable: true),
                    PostModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Like_Post_PostModelId",
                        column: x => x.PostModelId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Like_Usuario_Usario1Id",
                        column: x => x.Usario1Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Like_Usuario_Usario2Id",
                        column: x => x.Usario2Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UsuarioId",
                table: "Comment",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UsuarioPostId",
                table: "Comment",
                column: "UsuarioPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Dislike_Usario1Id",
                table: "Dislike",
                column: "Usario1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Dislike_Usario2Id",
                table: "Dislike",
                column: "Usario2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Like_PostModelId",
                table: "Like",
                column: "PostModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_Usario1Id",
                table: "Like",
                column: "Usario1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Like_Usario2Id",
                table: "Like",
                column: "Usario2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UsuarioPostId",
                table: "Post",
                column: "UsuarioPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Dislike");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.AddColumn<string>(
                name: "UploadPictureUrl",
                table: "Usuario",
                nullable: true);
        }
    }
}
