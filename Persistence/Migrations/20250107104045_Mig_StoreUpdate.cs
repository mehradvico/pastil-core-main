using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_StoreUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "Stores",
                type: "bigint",
                nullable: false,
                defaultValue: 169);

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "Stores",
                type: "bigint",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CityId",
                table: "Stores",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_TypeId",
                table: "Stores",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Cities_CityId",
                table: "Stores",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Codes_TypeId",
                table: "Stores",
                column: "TypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Cities_CityId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Codes_TypeId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_CityId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_TypeId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Stores");
        }
    }
}
