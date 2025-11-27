using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_CompaniUserFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_Users_CompanionUserId",
                table: "CompanionReserves");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_CompanionUsers_CompanionUserId",
                table: "CompanionReserves",
                column: "CompanionUserId",
                principalTable: "CompanionUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_CompanionUsers_CompanionUserId",
                table: "CompanionReserves");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_Users_CompanionUserId",
                table: "CompanionReserves",
                column: "CompanionUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
