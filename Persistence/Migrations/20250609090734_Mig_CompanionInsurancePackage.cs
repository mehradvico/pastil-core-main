using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_CompanionInsurancePackage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanionInsurancePackages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayCount = table.Column<int>(type: "int", nullable: false),
                    CompanionId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PetId = table.Column<long>(type: "bigint", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ActivationValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionInsurancePackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionInsurancePackages_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionInsurancePackages_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionInsurancePackageSales",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionInsurancePackageId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UserPetId = table.Column<long>(type: "bigint", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionInsurancePackageSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionInsurancePackageSales_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionInsurancePackageSales_CompanionInsurancePackages_CompanionInsurancePackageId",
                        column: x => x.CompanionInsurancePackageId,
                        principalTable: "CompanionInsurancePackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionInsurancePackageSales_UserPets_UserPetId",
                        column: x => x.UserPetId,
                        principalTable: "UserPets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionInsurancePackages_CompanionId",
                table: "CompanionInsurancePackages",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionInsurancePackages_PetId",
                table: "CompanionInsurancePackages",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionInsurancePackageSales_AddressId",
                table: "CompanionInsurancePackageSales",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionInsurancePackageSales_CompanionInsurancePackageId",
                table: "CompanionInsurancePackageSales",
                column: "CompanionInsurancePackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionInsurancePackageSales_UserPetId",
                table: "CompanionInsurancePackageSales",
                column: "UserPetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionInsurancePackageSales");

            migrationBuilder.DropTable(
                name: "CompanionInsurancePackages");
        }
    }
}
