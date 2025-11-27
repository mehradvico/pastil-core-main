using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_TripAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PictureId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoneDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "TripAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<Point>(type: "geography", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripAddresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PictureId",
                table: "Users",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionPet_PetsId",
                table: "CompanionPet",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_TripAddresses_UserId",
                table: "TripAddresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Pictures_PictureId",
                table: "Users",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Pictures_PictureId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CompanionPet");

            migrationBuilder.DropTable(
                name: "TripAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Users_PictureId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DoneDate",
                table: "CompanionReserves");
        }
    }
}
