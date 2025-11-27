using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_companionFix50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "Companions",
                type: "bigint",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CancelDetail",
                table: "CompanionReserves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCancel",
                table: "CompanionReserves",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Companions_TypeId",
                table: "Companions",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companions_Codes_TypeId",
                table: "Companions",
                column: "TypeId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companions_Codes_TypeId",
                table: "Companions");

            migrationBuilder.DropIndex(
                name: "IX_Companions_TypeId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "CancelDate",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "CancelDetail",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "IsCancel",
                table: "CompanionReserves");
        }
    }
}
