using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_NewCompinoionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoldAccount",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "SilverAccount",
                table: "Companions");

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "WeekDays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "WeekDays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ProductReports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CompanionUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CompanionUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "GoldAccountDate",
                table: "Companions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilverAccountDate",
                table: "Companions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CompanionAssistanceTimes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CompanionAssistanceTimes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "CompanionAssistances",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "WeekDays");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "WeekDays");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ProductReports");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "CompanionUsers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CompanionUsers");

            migrationBuilder.DropColumn(
                name: "GoldAccountDate",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "SilverAccountDate",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "DoDate",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "CompanionAssistanceTimes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CompanionAssistanceTimes");

            migrationBuilder.DropColumn(
                name: "Approved",
                table: "CompanionAssistances");

            migrationBuilder.AddColumn<bool>(
                name: "GoldAccount",
                table: "Companions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SilverAccount",
                table: "Companions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
