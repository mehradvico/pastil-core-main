using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_RebateTripInsurance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaymentPrice",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "RebateId",
                table: "Trips",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RebatePrice",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "CompanionInsurancePackageSales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaymentPrice",
                table: "CompanionInsurancePackageSales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "RebateId",
                table: "CompanionInsurancePackageSales",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RebatePrice",
                table: "CompanionInsurancePackageSales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_RebateId",
                table: "Trips",
                column: "RebateId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionInsurancePackageSales_RebateId",
                table: "CompanionInsurancePackageSales",
                column: "RebateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionInsurancePackageSales_Rebate_RebateId",
                table: "CompanionInsurancePackageSales",
                column: "RebateId",
                principalTable: "Rebate",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Rebate_RebateId",
                table: "Trips",
                column: "RebateId",
                principalTable: "Rebate",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionInsurancePackageSales_Rebate_RebateId",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Rebate_RebateId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_RebateId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_CompanionInsurancePackageSales_RebateId",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PaymentPrice",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "RebateId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "RebatePrice",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropColumn(
                name: "PaymentPrice",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropColumn(
                name: "RebateId",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropColumn(
                name: "RebatePrice",
                table: "CompanionInsurancePackageSales");
        }
    }
}
