using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Insurance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CompanionInsurancePackageSaleId",
                table: "Payments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "CompanionInsurancePackageSales",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManualPayDate",
                table: "CompanionInsurancePackageSales",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanionInsurancePackageSaleId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropColumn(
                name: "ManualPayDate",
                table: "CompanionInsurancePackageSales");
        }
    }
}
