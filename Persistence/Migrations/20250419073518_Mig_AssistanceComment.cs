using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_AssistanceComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<long>(
                name: "CompanionAssistanceTypeId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "CodeCompanionAssistance",
                columns: table => new
                {
                    CodesId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionAssistancesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeCompanionAssistance", x => new { x.CodesId, x.CompanionAssistancesId });
                    table.ForeignKey(
                        name: "FK_CodeCompanionAssistance_Codes_CodesId",
                        column: x => x.CodesId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodeCompanionAssistance_CompanionAssistances_CompanionAssistancesId",
                        column: x => x.CompanionAssistancesId,
                        principalTable: "CompanionAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_CompanionAssistanceTypeId",
                table: "CompanionReserves",
                column: "CompanionAssistanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeCompanionAssistance_CompanionAssistancesId",
                table: "CodeCompanionAssistance",
                column: "CompanionAssistancesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_Codes_CompanionAssistanceTypeId",
                table: "CompanionReserves",
                column: "CompanionAssistanceTypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_Codes_CompanionAssistanceTypeId",
                table: "CompanionReserves");

            migrationBuilder.DropTable(
                name: "CodeCompanionAssistance");

            migrationBuilder.DropIndex(
                name: "IX_CompanionReserves_CompanionAssistanceTypeId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "CompanionAssistanceTypeId",
                table: "CompanionReserves");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CancelDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
