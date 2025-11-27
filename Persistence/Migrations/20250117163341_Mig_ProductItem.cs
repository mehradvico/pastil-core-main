using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_ProductItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Warranty",
                table: "Stores");

            migrationBuilder.AddColumn<string>(
                name: "Warranty",
                table: "ProductItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Warranty",
                table: "ProductItems");

            migrationBuilder.AddColumn<string>(
                name: "Warranty",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
