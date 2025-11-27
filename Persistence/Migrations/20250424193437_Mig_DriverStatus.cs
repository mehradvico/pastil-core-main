using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_DriverStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Codes_TypeId",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Driver",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_TypeId",
                table: "Driver",
                newName: "IX_Driver_StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Codes_StatusId",
                table: "Driver",
                column: "StatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Codes_StatusId",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Driver",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_StatusId",
                table: "Driver",
                newName: "IX_Driver_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Codes_TypeId",
                table: "Driver",
                column: "TypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
