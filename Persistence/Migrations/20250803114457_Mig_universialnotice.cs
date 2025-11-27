using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_universialnotice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserTypeId",
                table: "Notices",
                type: "bigint",
                nullable: false,
                defaultValue: 10077);

            migrationBuilder.CreateIndex(
                name: "IX_Notices_UserTypeId",
                table: "Notices",
                column: "UserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notices_Codes_UserTypeId",
                table: "Notices",
                column: "UserTypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notices_Codes_UserTypeId",
                table: "Notices");

            migrationBuilder.DropIndex(
                name: "IX_Notices_UserTypeId",
                table: "Notices");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "Notices");
        }
    }
}
