using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_WalletAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Wallets_CompanionInsurancePackageSaleId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_CompanionReserveId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_TripId",
                table: "Wallets");

            migrationBuilder.AddColumn<bool>(
                name: "FromWallet",
                table: "Trips",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "WalletPrice",
                table: "Trips",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "FromWallet",
                table: "CompanionReserves",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "WalletPrice",
                table: "CompanionReserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "FromWallet",
                table: "CompanionInsurancePackageSales",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "WalletPrice",
                table: "CompanionInsurancePackageSales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CompanionInsurancePackageSaleId",
                table: "Wallets",
                column: "CompanionInsurancePackageSaleId",
                unique: true,
                filter: "[CompanionInsurancePackageSaleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CompanionReserveId",
                table: "Wallets",
                column: "CompanionReserveId",
                unique: true,
                filter: "[CompanionReserveId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_TripId",
                table: "Wallets",
                column: "TripId",
                unique: true,
                filter: "[TripId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Wallets_CompanionInsurancePackageSaleId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_CompanionReserveId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_TripId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "FromWallet",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "WalletPrice",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "FromWallet",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "WalletPrice",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "FromWallet",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.DropColumn(
                name: "WalletPrice",
                table: "CompanionInsurancePackageSales");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CompanionInsurancePackageSaleId",
                table: "Wallets",
                column: "CompanionInsurancePackageSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CompanionReserveId",
                table: "Wallets",
                column: "CompanionReserveId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_TripId",
                table: "Wallets",
                column: "TripId");
        }
    }
}
