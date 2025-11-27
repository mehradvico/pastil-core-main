using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Users_OwnerId1",
                table: "Companions");

            migrationBuilder.DropIndex(
                name: "IX_Companions_OwnerId1",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "Companions");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Users_OwnerId",
                table: "Companions",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Users_OwnerId",
                table: "Companions");

            migrationBuilder.DropIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions");

            migrationBuilder.AddColumn<long>(
                name: "OwnerId1",
                table: "Companions",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId1",
                table: "Companions",
                column: "OwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Users_OwnerId1",
                table: "Companions",
                column: "OwnerId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
