using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_AnswerLike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "DiscussionQuestions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "DisLikeCount",
                table: "DiscussionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LikeCount",
                table: "DiscussionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DiscussionAnswerLikes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsLike = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscussionAnswerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionAnswerLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscussionAnswerLikes_DiscussionAnswers_DiscussionAnswerId",
                        column: x => x.DiscussionAnswerId,
                        principalTable: "DiscussionAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DiscussionAnswerLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionQuestions_UserId",
                table: "DiscussionQuestions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionAnswerLikes_DiscussionAnswerId",
                table: "DiscussionAnswerLikes",
                column: "DiscussionAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionAnswerLikes_UserId",
                table: "DiscussionAnswerLikes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscussionQuestions_Users_UserId",
                table: "DiscussionQuestions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscussionQuestions_Users_UserId",
                table: "DiscussionQuestions");

            migrationBuilder.DropTable(
                name: "DiscussionAnswerLikes");

            migrationBuilder.DropIndex(
                name: "IX_DiscussionQuestions_UserId",
                table: "DiscussionQuestions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DiscussionQuestions");

            migrationBuilder.DropColumn(
                name: "DisLikeCount",
                table: "DiscussionAnswers");

            migrationBuilder.DropColumn(
                name: "LikeCount",
                table: "DiscussionAnswers");
        }
    }
}
