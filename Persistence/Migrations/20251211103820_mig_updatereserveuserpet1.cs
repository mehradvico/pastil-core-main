using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mig_updatereserveuserpet1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_UserPets_UserPetId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "UserPetId",
                table: "CompanionReserves");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserPetId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_UserPetId",
                table: "CompanionReserves",
                column: "UserPetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_UserPets_UserPetId",
                table: "CompanionReserves",
                column: "UserPetId",
                principalTable: "UserPets",
                principalColumn: "Id");
        }
    }
}
