using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_bgpiccompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BackgroundPictureId",
                table: "Companions",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companions_BackgroundPictureId",
                table: "Companions",
                column: "BackgroundPictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Pictures_BackgroundPictureId",
                table: "Companions",
                column: "BackgroundPictureId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Pictures_BackgroundPictureId",
                table: "Companions");

            migrationBuilder.DropIndex(
                name: "IX_Companions_BackgroundPictureId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "BackgroundPictureId",
                table: "Companions");
        }
    }
}
