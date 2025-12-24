using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_pansionUpdate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Pansions",
                newName: "SchoolPrice");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSchool",
                table: "Pansions",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<double>(
                name: "PansionPrice",
                table: "Pansions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "DayCount",
                table: "PansionReserves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HourCount",
                table: "PansionReserves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SchoolCreateDate",
                table: "PansionReserves",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PansionPrice",
                table: "Pansions");

            migrationBuilder.DropColumn(
                name: "DayCount",
                table: "PansionReserves");

            migrationBuilder.DropColumn(
                name: "HourCount",
                table: "PansionReserves");

            migrationBuilder.DropColumn(
                name: "SchoolCreateDate",
                table: "PansionReserves");

            migrationBuilder.RenameColumn(
                name: "SchoolPrice",
                table: "Pansions",
                newName: "Price");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSchool",
                table: "Pansions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
