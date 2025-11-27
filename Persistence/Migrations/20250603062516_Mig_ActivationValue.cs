using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_ActivationValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActivationValue",
                table: "CompanionUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivationValue",
                table: "Companions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivationValue",
                table: "CompanionAssistanceUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivationValue",
                table: "CompanionAssistances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActivationValue",
                table: "CompanionAssistancePackages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivationValue",
                table: "CompanionUsers");

            migrationBuilder.DropColumn(
                name: "ActivationValue",
                table: "Companions");

            migrationBuilder.DropColumn(
                name: "ActivationValue",
                table: "CompanionAssistanceUsers");

            migrationBuilder.DropColumn(
                name: "ActivationValue",
                table: "CompanionAssistances");

            migrationBuilder.DropColumn(
                name: "ActivationValue",
                table: "CompanionAssistancePackages");
        }
    }
}
