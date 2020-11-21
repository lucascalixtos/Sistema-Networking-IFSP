using Microsoft.EntityFrameworkCore.Migrations;

namespace PlataformaNetworking.Migrations
{
    public partial class Likes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Post_PostModelId",
                table: "Like");

            migrationBuilder.DropIndex(
                name: "IX_Like_PostModelId",
                table: "Like");

            migrationBuilder.DropColumn(
                name: "PostModelId",
                table: "Like");

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Post",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like",
                table: "Post");

            migrationBuilder.AddColumn<int>(
                name: "PostModelId",
                table: "Like",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Like_PostModelId",
                table: "Like",
                column: "PostModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Post_PostModelId",
                table: "Like",
                column: "PostModelId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
