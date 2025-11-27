using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_fix_reminder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MonthNumber",
                table: "Reminders",
                newName: "AlertSentCount");

            migrationBuilder.RenameColumn(
                name: "LastSentDate",
                table: "Reminders",
                newName: "LastSentDate2");

            migrationBuilder.RenameColumn(
                name: "DayNumber",
                table: "Reminders",
                newName: "AlertCount");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSentDate1",
                table: "Reminders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Reminders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastSentDate1",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Reminders");

            migrationBuilder.RenameColumn(
                name: "LastSentDate2",
                table: "Reminders",
                newName: "LastSentDate");

            migrationBuilder.RenameColumn(
                name: "AlertSentCount",
                table: "Reminders",
                newName: "MonthNumber");

            migrationBuilder.RenameColumn(
                name: "AlertCount",
                table: "Reminders",
                newName: "DayNumber");
        }
    }
}
