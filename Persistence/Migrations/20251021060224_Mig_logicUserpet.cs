using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_logicUserpet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_UserPets_UserPetId",
                table: "Trips");

            migrationBuilder.AlterColumn<long>(
                name: "UserPetId",
                table: "Trips",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_UserPets_UserPetId",
                table: "Trips",
                column: "UserPetId",
                principalTable: "UserPets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_UserPets_UserPetId",
                table: "Trips");

            migrationBuilder.AlterColumn<long>(
                name: "UserPetId",
                table: "Trips",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_UserPets_UserPetId",
                table: "Trips",
                column: "UserPetId",
                principalTable: "UserPets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
