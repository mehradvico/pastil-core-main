using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_ReserveComp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CompanionReserveId",
                table: "Payments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "CompanionReserves",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "StateId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_StateId",
                table: "CompanionReserves",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_Codes_StateId",
                table: "CompanionReserves",
                column: "StateId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_Codes_StateId",
                table: "CompanionReserves");

            migrationBuilder.DropIndex(
                name: "IX_CompanionReserves_StateId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "CompanionReserveId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "CompanionReserves");
        }
    }
}
