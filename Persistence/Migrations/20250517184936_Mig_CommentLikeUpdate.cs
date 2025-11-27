using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_CommentLikeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownThumb",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UpThumb",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "DisLike",
                table: "CommentLikes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisLike",
                table: "CommentLikes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "CommentLikes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "CommentLikes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserId",
                table: "CommentLikes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_Users_UserId",
                table: "CommentLikes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Users_UserId",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_UserId",
                table: "CommentLikes");

            migrationBuilder.DropColumn(
                name: "DisLike",
                table: "CommentLikes");

            migrationBuilder.DropColumn(
                name: "IsDisLike",
                table: "CommentLikes");

            migrationBuilder.DropColumn(
                name: "Like",
                table: "CommentLikes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CommentLikes");

            migrationBuilder.AddColumn<int>(
                name: "DownThumb",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpThumb",
                table: "Comments",
                type: "int",
                nullable: true);
        }
    }
}
