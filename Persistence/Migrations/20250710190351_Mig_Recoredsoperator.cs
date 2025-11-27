using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Recoredsoperator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OperatorChangeStateDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatorDetail",
                table: "CompanionReserves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OperatorStateId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: false,
                defaultValue: 10066);

            migrationBuilder.AddColumn<bool>(
                name: "UserResponse",
                table: "CompanionReserves",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserPetRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserPetId = table.Column<long>(type: "bigint", nullable: false),
                    OperatorId = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPetRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPetRecords_UserPets_UserPetId",
                        column: x => x.UserPetId,
                        principalTable: "UserPets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPetRecords_Users_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_OperatorStateId",
                table: "CompanionReserves",
                column: "OperatorStateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPetRecords_OperatorId",
                table: "UserPetRecords",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPetRecords_UserPetId",
                table: "UserPetRecords",
                column: "UserPetId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_Codes_OperatorStateId",
                table: "CompanionReserves",
                column: "OperatorStateId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_Codes_OperatorStateId",
                table: "CompanionReserves");

            migrationBuilder.DropTable(
                name: "UserPetRecords");

            migrationBuilder.DropIndex(
                name: "IX_CompanionReserves_OperatorStateId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "OperatorChangeStateDate",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "OperatorDetail",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "OperatorStateId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "UserResponse",
                table: "CompanionReserves");
        }
    }
}
