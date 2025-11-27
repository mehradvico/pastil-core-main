using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_DetailPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DefaultPrice",
                table: "Cargoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NotAccompanyPrice",
                table: "Cargoes",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ReturnPrice",
                table: "Cargoes",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultPrice",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "NotAccompanyPrice",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "ReturnPrice",
                table: "Cargoes");
        }
    }
}
