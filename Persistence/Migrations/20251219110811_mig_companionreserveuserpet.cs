using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_companionreserveuserpet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPets_CompanionReserves_CompanionReserveId",
                table: "UserPets");

            migrationBuilder.DropIndex(
                name: "IX_UserPets_CompanionReserveId",
                table: "UserPets");

            migrationBuilder.DropColumn(
                name: "CompanionReserveId",
                table: "UserPets");

            migrationBuilder.CreateTable(
                name: "CompanionReserveUserPet",
                columns: table => new
                {
                    CompanionReservesId = table.Column<long>(type: "bigint", nullable: false),
                    UserPetsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionReserveUserPet", x => new { x.CompanionReservesId, x.UserPetsId });
                    table.ForeignKey(
                        name: "FK_CompanionReserveUserPet_CompanionReserves_CompanionReservesId",
                        column: x => x.CompanionReservesId,
                        principalTable: "CompanionReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReserveUserPet_UserPets_UserPetsId",
                        column: x => x.UserPetsId,
                        principalTable: "UserPets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserveUserPet_UserPetsId",
                table: "CompanionReserveUserPet",
                column: "UserPetsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionReserveUserPet");

            migrationBuilder.AddColumn<long>(
                name: "CompanionReserveId",
                table: "UserPets",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPets_CompanionReserveId",
                table: "UserPets",
                column: "CompanionReserveId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPets_CompanionReserves_CompanionReserveId",
                table: "UserPets",
                column: "CompanionReserveId",
                principalTable: "CompanionReserves",
                principalColumn: "Id");
        }
    }
}
