using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_vari4354343534 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_VarietyId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VarietyId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VarietyId1",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products");

            migrationBuilder.AddColumn<long>(
                name: "VarietyId1",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_VarietyId1",
                table: "Products",
                column: "VarietyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_VarietyId",
                table: "Products",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_VarietyId1",
                table: "Products",
                column: "VarietyId1",
                principalTable: "Varieties",
                principalColumn: "Id");
        }
    }
}
