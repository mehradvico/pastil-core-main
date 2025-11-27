using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_timereserveset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_CompanionAssistanceTimes_CompanionAssistanceTimeId",
                table: "CompanionReserves");

            migrationBuilder.AlterColumn<long>(
                name: "CompanionAssistanceTimeId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_CompanionAssistanceTimes_CompanionAssistanceTimeId",
                table: "CompanionReserves",
                column: "CompanionAssistanceTimeId",
                principalTable: "CompanionAssistanceTimes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_CompanionAssistanceTimes_CompanionAssistanceTimeId",
                table: "CompanionReserves");

            migrationBuilder.AlterColumn<long>(
                name: "CompanionAssistanceTimeId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_CompanionAssistanceTimes_CompanionAssistanceTimeId",
                table: "CompanionReserves",
                column: "CompanionAssistanceTimeId",
                principalTable: "CompanionAssistanceTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
