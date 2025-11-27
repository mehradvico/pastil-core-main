using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Trip3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "To",
                table: "Trips",
                newName: "SecondDestination");

            migrationBuilder.RenameColumn(
                name: "From",
                table: "Trips",
                newName: "Origin");

            migrationBuilder.AddColumn<Point>(
                name: "Destination",
                table: "Trips",
                type: "geography",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RoundTrip",
                table: "Trips",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StopTime",
                table: "Trips",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "RoundTrip",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "StopTime",
                table: "Trips");

            migrationBuilder.RenameColumn(
                name: "SecondDestination",
                table: "Trips",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "Origin",
                table: "Trips",
                newName: "From");
        }
    }
}
