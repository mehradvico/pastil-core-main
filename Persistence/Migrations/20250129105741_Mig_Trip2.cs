using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Trip2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Cities_FromCityId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Codes_DriverStatusId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Codes_TripStatusId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Users_DriverId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Users_PassengerId",
                table: "Trip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trip",
                table: "Trip");

            migrationBuilder.RenameTable(
                name: "Trip",
                newName: "Trips");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_TripStatusId",
                table: "Trips",
                newName: "IX_Trips_TripStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_PassengerId",
                table: "Trips",
                newName: "IX_Trips_PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_FromCityId",
                table: "Trips",
                newName: "IX_Trips_FromCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_DriverStatusId",
                table: "Trips",
                newName: "IX_Trips_DriverStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Trip_DriverId",
                table: "Trips",
                newName: "IX_Trips_DriverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trips",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Cities_FromCityId",
                table: "Trips",
                column: "FromCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Codes_DriverStatusId",
                table: "Trips",
                column: "DriverStatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Codes_TripStatusId",
                table: "Trips",
                column: "TripStatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Users_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Users_PassengerId",
                table: "Trips",
                column: "PassengerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Cities_FromCityId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Codes_DriverStatusId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Codes_TripStatusId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Users_DriverId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Users_PassengerId",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.RenameTable(
                name: "Trips",
                newName: "Trip");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_TripStatusId",
                table: "Trip",
                newName: "IX_Trip_TripStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_PassengerId",
                table: "Trip",
                newName: "IX_Trip_PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_FromCityId",
                table: "Trip",
                newName: "IX_Trip_FromCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_DriverStatusId",
                table: "Trip",
                newName: "IX_Trip_DriverStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_DriverId",
                table: "Trip",
                newName: "IX_Trip_DriverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trip",
                table: "Trip",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Cities_FromCityId",
                table: "Trip",
                column: "FromCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Codes_DriverStatusId",
                table: "Trip",
                column: "DriverStatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Codes_TripStatusId",
                table: "Trip",
                column: "TripStatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Users_DriverId",
                table: "Trip",
                column: "DriverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Users_PassengerId",
                table: "Trip",
                column: "PassengerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
