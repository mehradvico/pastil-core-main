using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_UserPetPic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PictureId",
                table: "UserPets",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPets_PictureId",
                table: "UserPets",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPets_Pictures_PictureId",
                table: "UserPets",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPets_Pictures_PictureId",
                table: "UserPets");

            migrationBuilder.DropIndex(
                name: "IX_UserPets_PictureId",
                table: "UserPets");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "UserPets");
        }
    }
}
