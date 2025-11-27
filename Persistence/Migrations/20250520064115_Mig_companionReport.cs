using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_companionReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanionAssistanceReports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    ReportValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistanceReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionAssistanceReports_CompanionAssistances_CompanionAssistanceId",
                        column: x => x.CompanionAssistanceId,
                        principalTable: "CompanionAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionAssistanceReports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionReports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionId = table.Column<long>(type: "bigint", nullable: false),
                    ReportValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionReports_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistanceReports_CompanionAssistanceId",
                table: "CompanionAssistanceReports",
                column: "CompanionAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistanceReports_UserId",
                table: "CompanionAssistanceReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReports_CompanionId",
                table: "CompanionReports",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReports_UserId",
                table: "CompanionReports",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionAssistanceReports");

            migrationBuilder.DropTable(
                name: "CompanionReports");
        }
    }
}
