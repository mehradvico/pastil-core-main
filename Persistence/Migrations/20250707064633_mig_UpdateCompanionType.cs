using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_UpdateCompanionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeCompanionAssistance_Codes_CodesId",
                table: "CodeCompanionAssistance");

            migrationBuilder.DropForeignKey(
                name: "FK_CodeCompanionAssistance_CompanionAssistances_CompanionAssistancesId",
                table: "CodeCompanionAssistance");

            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Codes_TypeId",
                table: "Companions");

            migrationBuilder.DropIndex(
                name: "IX_Companions_TypeId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Companions");

            migrationBuilder.AddColumn<long>(
                name: "CompanionTypeId",
                table: "CompanionAssistances",
                type: "bigint",
                nullable: false,
                defaultValue: 10021);

            migrationBuilder.CreateTable(
                name: "CodeCompanion",
                columns: table => new
                {
                    CompanionsId = table.Column<long>(type: "bigint", nullable: false),
                    TypesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeCompanion", x => new { x.CompanionsId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_CodeCompanion_Codes_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CodeCompanion_Companions_CompanionsId",
                        column: x => x.CompanionsId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistances_CompanionTypeId",
                table: "CompanionAssistances",
                column: "CompanionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeCompanion_TypesId",
                table: "CodeCompanion",
                column: "TypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeCompanionAssistance_Codes_CodesId",
                table: "CodeCompanionAssistance",
                column: "CodesId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CodeCompanionAssistance_CompanionAssistances_CompanionAssistancesId",
                table: "CodeCompanionAssistance",
                column: "CompanionAssistancesId",
                principalTable: "CompanionAssistances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionAssistances_Codes_CompanionTypeId",
                table: "CompanionAssistances",
                column: "CompanionTypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeCompanionAssistance_Codes_CodesId",
                table: "CodeCompanionAssistance");

            migrationBuilder.DropForeignKey(
                name: "FK_CodeCompanionAssistance_CompanionAssistances_CompanionAssistancesId",
                table: "CodeCompanionAssistance");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanionAssistances_Codes_CompanionTypeId",
                table: "CompanionAssistances");

            migrationBuilder.DropTable(
                name: "CodeCompanion");

            migrationBuilder.DropIndex(
                name: "IX_CompanionAssistances_CompanionTypeId",
                table: "CompanionAssistances");

            migrationBuilder.DropColumn(
                name: "CompanionTypeId",
                table: "CompanionAssistances");

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "Companions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Companions_TypeId",
                table: "Companions",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeCompanionAssistance_Codes_CodesId",
                table: "CodeCompanionAssistance",
                column: "CodesId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CodeCompanionAssistance_CompanionAssistances_CompanionAssistancesId",
                table: "CodeCompanionAssistance",
                column: "CompanionAssistancesId",
                principalTable: "CompanionAssistances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Codes_TypeId",
                table: "Companions",
                column: "TypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
