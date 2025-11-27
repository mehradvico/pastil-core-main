using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Shareprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DriverShare",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SiteShare",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SharePercent",
                table: "Companions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "CompanionShare",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SiteShare",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverShare",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "SiteShare",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "SharePercent",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "CompanionShare",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "SiteShare",
                table: "CompanionReserves");
        }
    }
}
