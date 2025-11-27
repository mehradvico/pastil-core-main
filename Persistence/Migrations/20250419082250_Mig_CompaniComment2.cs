using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_CompaniComment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssistanceQuestionnaires",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    AssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistanceQuestionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssistanceQuestionnaires_Assistances_AssistanceId",
                        column: x => x.AssistanceId,
                        principalTable: "Assistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionReserveComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionReserveId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionReserveComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionReserveComments_CompanionReserves_CompanionReserveId",
                        column: x => x.CompanionReserveId,
                        principalTable: "CompanionReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionReserveCommentRates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    AssistanceQuestionnaireId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionReserveCommentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionReserveCommentRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionReserveCommentRates_AssistanceQuestionnaires_AssistanceQuestionnaireId",
                        column: x => x.AssistanceQuestionnaireId,
                        principalTable: "AssistanceQuestionnaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReserveCommentRates_CompanionReserveComments_CompanionReserveCommentId",
                        column: x => x.CompanionReserveCommentId,
                        principalTable: "CompanionReserveComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssistanceQuestionnaires_AssistanceId",
                table: "AssistanceQuestionnaires",
                column: "AssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserveCommentRates_AssistanceQuestionnaireId",
                table: "CompanionReserveCommentRates",
                column: "AssistanceQuestionnaireId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserveCommentRates_CompanionReserveCommentId",
                table: "CompanionReserveCommentRates",
                column: "CompanionReserveCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserveComments_CompanionReserveId",
                table: "CompanionReserveComments",
                column: "CompanionReserveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionReserveCommentRates");

            migrationBuilder.DropTable(
                name: "AssistanceQuestionnaires");

            migrationBuilder.DropTable(
                name: "CompanionReserveComments");
        }
    }
}
