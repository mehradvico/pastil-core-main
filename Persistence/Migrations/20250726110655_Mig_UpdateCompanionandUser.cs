using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_UpdateCompanionandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions",
                column: "OwnerId",
                unique: true);
        }
    }
}
