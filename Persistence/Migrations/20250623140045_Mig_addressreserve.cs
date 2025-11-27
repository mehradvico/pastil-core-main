using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_addressreserve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AddressId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_AddressId",
                table: "CompanionReserves",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_Addresses_AddressId",
                table: "CompanionReserves",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_Addresses_AddressId",
                table: "CompanionReserves");

            migrationBuilder.DropIndex(
                name: "IX_CompanionReserves_AddressId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "CompanionReserves");
        }
    }
}
