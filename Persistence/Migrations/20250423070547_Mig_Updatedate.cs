using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Updatedate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Users_OwnerId",
                table: "Companions");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Users_DriverId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "CompanionId",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Users_OwnerId",
                table: "Companions",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Companions_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Companions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Users_OwnerId",
                table: "Companions");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Companions_DriverId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions");

            migrationBuilder.AddColumn<long>(
                name: "CompanionId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Users_OwnerId",
                table: "Companions",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Users_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
