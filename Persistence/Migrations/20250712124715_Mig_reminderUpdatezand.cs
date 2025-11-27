using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_reminderUpdatezand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlertCount",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "AlertSentCount",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "LastSentDate1",
                table: "Reminders");

            migrationBuilder.RenameColumn(
                name: "LastSentDate2",
                table: "Reminders",
                newName: "LastChecked");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastChecked",
                table: "Reminders",
                newName: "LastSentDate2");

            migrationBuilder.AddColumn<int>(
                name: "AlertCount",
                table: "Reminders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlertSentCount",
                table: "Reminders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSentDate1",
                table: "Reminders",
                type: "datetime2",
                nullable: true);
        }
    }
}
