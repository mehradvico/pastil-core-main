using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_commentreserve2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanionReserveComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CompanionReserveId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionReserveComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionReserveComments_Comments_Id",
                        column: x => x.Id,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanionReserveComments_CompanionReserves_CompanionReserveId",
                        column: x => x.CompanionReserveId,
                        principalTable: "CompanionReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserveCommentRates_CompanionReserveCommentId",
                table: "CompanionReserveCommentRates",
                column: "CompanionReserveCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserveComments_CompanionReserveId",
                table: "CompanionReserveComments",
                column: "CompanionReserveId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserveCommentRates_CompanionReserveComments_CompanionReserveCommentId",
                table: "CompanionReserveCommentRates",
                column: "CompanionReserveCommentId",
                principalTable: "CompanionReserveComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserveCommentRates_CompanionReserveComments_CompanionReserveCommentId",
                table: "CompanionReserveCommentRates");

            migrationBuilder.DropTable(
                name: "CompanionReserveComments");

            migrationBuilder.DropIndex(
                name: "IX_CompanionReserveCommentRates_CompanionReserveCommentId",
                table: "CompanionReserveCommentRates");
        }
    }
}
