using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_RebateType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "Rebate",
                type: "bigint",
                nullable: false,
                defaultValue: 10069);

            migrationBuilder.CreateIndex(
                name: "IX_Rebate_TypeId",
                table: "Rebate",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rebate_Codes_TypeId",
                table: "Rebate",
                column: "TypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rebate_Codes_TypeId",
                table: "Rebate");

            migrationBuilder.DropIndex(
                name: "IX_Rebate_TypeId",
                table: "Rebate");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Rebate");
        }
    }
}
