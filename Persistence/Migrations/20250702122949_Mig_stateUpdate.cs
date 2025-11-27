using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_stateUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnName",
                table: "States",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndTime",
                table: "CompanionReserves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FromDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "CompanionReserves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ToDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnName",
                table: "States");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "ToDate",
                table: "CompanionReserves");
        }
    }
}
