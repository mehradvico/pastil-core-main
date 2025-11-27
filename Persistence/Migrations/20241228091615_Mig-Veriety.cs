using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigVeriety : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GroupPriority",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GroupTitle",
                table: "Products");

            migrationBuilder.AddColumn<long>(
                name: "Variety2Id",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VarietyId1",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VarietyItem2Id",
                table: "ProductItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Variety2Id",
                table: "Products",
                column: "Variety2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VarietyId1",
                table: "Products",
                column: "VarietyId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_VarietyItem2Id",
                table: "ProductItems",
                column: "VarietyItem2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_VarietyItems_VarietyItem2Id",
                table: "ProductItems",
                column: "VarietyItem2Id",
                principalTable: "VarietyItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_Variety2Id",
                table: "Products",
                column: "Variety2Id",
                principalTable: "Varieties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Varieties_VarietyId1",
                table: "Products",
                column: "VarietyId1",
                principalTable: "Varieties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_VarietyItems_VarietyItem2Id",
                table: "ProductItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_Variety2Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Varieties_VarietyId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Variety2Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VarietyId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductItems_VarietyItem2Id",
                table: "ProductItems");

            migrationBuilder.DropColumn(
                name: "Variety2Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VarietyId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VarietyItem2Id",
                table: "ProductItems");

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupPriority",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GroupTitle",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
