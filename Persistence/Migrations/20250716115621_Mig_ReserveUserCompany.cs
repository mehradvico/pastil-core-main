using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_ReserveUserCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_CompanionUsers_CompanionUserId",
                table: "CompanionReserves");

            migrationBuilder.RenameColumn(
                name: "CompanionUserId",
                table: "CompanionReserves",
                newName: "CompanionAssistanceUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanionReserves_CompanionUserId",
                table: "CompanionReserves",
                newName: "IX_CompanionReserves_CompanionAssistanceUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_CompanionAssistanceUsers_CompanionAssistanceUserId",
                table: "CompanionReserves",
                column: "CompanionAssistanceUserId",
                principalTable: "CompanionAssistanceUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_CompanionAssistanceUsers_CompanionAssistanceUserId",
                table: "CompanionReserves");

            migrationBuilder.RenameColumn(
                name: "CompanionAssistanceUserId",
                table: "CompanionReserves",
                newName: "CompanionUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanionReserves_CompanionAssistanceUserId",
                table: "CompanionReserves",
                newName: "IX_CompanionReserves_CompanionUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_CompanionUsers_CompanionUserId",
                table: "CompanionReserves",
                column: "CompanionUserId",
                principalTable: "CompanionUsers",
                principalColumn: "Id");
        }
    }
}
