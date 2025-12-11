using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_userpetreserve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_UserPets_UserPetId",
                table: "CompanionReserves");

            migrationBuilder.AddColumn<long>(
                name: "CompanionReserveId",
                table: "UserPets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserPetId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_UserPets_CompanionReserveId",
                table: "UserPets",
                column: "CompanionReserveId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_UserPets_UserPetId",
                table: "CompanionReserves",
                column: "UserPetId",
                principalTable: "UserPets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPets_CompanionReserves_CompanionReserveId",
                table: "UserPets",
                column: "CompanionReserveId",
                principalTable: "CompanionReserves",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_UserPets_UserPetId",
                table: "CompanionReserves");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPets_CompanionReserves_CompanionReserveId",
                table: "UserPets");

            migrationBuilder.DropIndex(
                name: "IX_UserPets_CompanionReserveId",
                table: "UserPets");

            migrationBuilder.DropColumn(
                name: "CompanionReserveId",
                table: "UserPets");

            migrationBuilder.AlterColumn<long>(
                name: "UserPetId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_UserPets_UserPetId",
                table: "CompanionReserves",
                column: "UserPetId",
                principalTable: "UserPets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
