using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_vari4354352 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_Variety2Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_Variety2Id",
                table: "Products",
                column: "Variety2Id",
                principalTable: "Varieties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_Variety2Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_Variety2Id",
                table: "Products",
                column: "Variety2Id",
                principalTable: "Varieties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "Id");
        }
    }
}
