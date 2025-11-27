using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_RAteUpdateZand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Companions",
                newName: "RateCount");

            migrationBuilder.AddColumn<double>(
                name: "RateAvg",
                table: "Companions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RateAvg",
                table: "Companions");

            migrationBuilder.RenameColumn(
                name: "RateCount",
                table: "Companions",
                newName: "Rate");
        }
    }
}
