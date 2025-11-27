using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_TripUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Users_PassengerId",
                table: "Trips");

            migrationBuilder.RenameColumn(
                name: "PassengerId",
                table: "Trips",
                newName: "UserPetId");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_PassengerId",
                table: "Trips",
                newName: "IX_Trips_UserPetId");

            migrationBuilder.AddColumn<long>(
                name: "TripStopId",
                table: "Trips",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UserAccept",
                table: "CompanionUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TripOptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripStops",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripStops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripTripOption",
                columns: table => new
                {
                    TripOptionsId = table.Column<long>(type: "bigint", nullable: false),
                    TripsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripTripOption", x => new { x.TripOptionsId, x.TripsId });
                    table.ForeignKey(
                        name: "FK_TripTripOption_TripOptions_TripOptionsId",
                        column: x => x.TripOptionsId,
                        principalTable: "TripOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TripTripOption_Trips_TripsId",
                        column: x => x.TripsId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TripStopId",
                table: "Trips",
                column: "TripStopId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTripOption_TripsId",
                table: "TripTripOption",
                column: "TripsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_TripStops_TripStopId",
                table: "Trips",
                column: "TripStopId",
                principalTable: "TripStops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_UserPets_UserPetId",
                table: "Trips",
                column: "UserPetId",
                principalTable: "UserPets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_TripStops_TripStopId",
                table: "Trips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_UserPets_UserPetId",
                table: "Trips");

            migrationBuilder.DropTable(
                name: "TripStops");

            migrationBuilder.DropTable(
                name: "TripTripOption");

            migrationBuilder.DropTable(
                name: "TripOptions");

            migrationBuilder.DropIndex(
                name: "IX_Trips_TripStopId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TripStopId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UserAccept",
                table: "CompanionUsers");

            migrationBuilder.RenameColumn(
                name: "UserPetId",
                table: "Trips",
                newName: "PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_Trips_UserPetId",
                table: "Trips",
                newName: "IX_Trips_PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Users_PassengerId",
                table: "Trips",
                column: "PassengerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
