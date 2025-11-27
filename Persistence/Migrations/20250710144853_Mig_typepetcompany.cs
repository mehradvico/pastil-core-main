using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_typepetcompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeCompanion");

            migrationBuilder.DropTable(
                name: "CompanionPet");

            migrationBuilder.AddColumn<long>(
                name: "CodeId",
                table: "Companions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PetId",
                table: "Companions",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanionPets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionId = table.Column<long>(type: "bigint", nullable: false),
                    PetId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionPets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionPets_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionId = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionTypes_Codes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionTypes_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companions_CodeId",
                table: "Companions",
                column: "CodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_PetId",
                table: "Companions",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionPets_CompanionId",
                table: "CompanionPets",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionPets_PetId",
                table: "CompanionPets",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionTypes_CompanionId",
                table: "CompanionTypes",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionTypes_TypeId",
                table: "CompanionTypes",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Codes_CodeId",
                table: "Companions",
                column: "CodeId",
                principalTable: "Codes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Pets_PetId",
                table: "Companions",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Codes_CodeId",
                table: "Companions");

            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Pets_PetId",
                table: "Companions");

            migrationBuilder.DropTable(
                name: "CompanionPets");

            migrationBuilder.DropTable(
                name: "CompanionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Companions_CodeId",
                table: "Companions");

            migrationBuilder.DropIndex(
                name: "IX_Companions_PetId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "CodeId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "Companions");

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

            migrationBuilder.CreateTable(
                name: "CompanionPet",
                columns: table => new
                {
                    CompanionsId = table.Column<long>(type: "bigint", nullable: false),
                    PetsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionPet", x => new { x.CompanionsId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_CompanionPet_Companions_CompanionsId",
                        column: x => x.CompanionsId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionPet_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodeCompanion_TypesId",
                table: "CodeCompanion",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionPet_PetsId",
                table: "CompanionPet",
                column: "PetsId");
        }
    }
}
