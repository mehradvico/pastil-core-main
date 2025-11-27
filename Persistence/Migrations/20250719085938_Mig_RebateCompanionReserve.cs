using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_RebateCompanionReserve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "CompanionReserves");

            migrationBuilder.AddColumn<string>(
                name: "CallBackId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CallBackTypeLabel",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "OperatorFinalPrice",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaymentPrice",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "RebateId",
                table: "CompanionReserves",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RebatePrice",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_RebateId",
                table: "CompanionReserves",
                column: "RebateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionReserves_Rebate_RebateId",
                table: "CompanionReserves",
                column: "RebateId",
                principalTable: "Rebate",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionReserves_Rebate_RebateId",
                table: "CompanionReserves");

            migrationBuilder.DropIndex(
                name: "IX_CompanionReserves_RebateId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "CallBackId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CallBackTypeLabel",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "OperatorFinalPrice",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "PaymentPrice",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "RebateId",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "RebatePrice",
                table: "CompanionReserves");

            migrationBuilder.AddColumn<double>(
                name: "FinalPrice",
                table: "CompanionReserves",
                type: "float",
                nullable: true);
        }
    }
}
