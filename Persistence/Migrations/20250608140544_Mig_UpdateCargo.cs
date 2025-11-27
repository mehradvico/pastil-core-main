using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_UpdateCargo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Cargoes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "StatusId",
                table: "Cargoes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Cargoes_StatusId",
                table: "Cargoes",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargoes_Codes_StatusId",
                table: "Cargoes",
                column: "StatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargoes_Codes_StatusId",
                table: "Cargoes");

            migrationBuilder.DropIndex(
                name: "IX_Cargoes_StatusId",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Cargoes");
        }
    }
}
