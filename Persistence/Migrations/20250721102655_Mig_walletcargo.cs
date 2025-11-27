using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_walletcargo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CargoId",
                table: "Wallets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CompanionInsurancePackageSaleId",
                table: "Wallets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CompanionReserveId",
                table: "Wallets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TripId",
                table: "Wallets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WalletPrice",
                table: "Cargoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_CargoId",
                table: "Wallets",
                column: "CargoId",
                unique: true,
                filter: "[CargoId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Cargoes_CargoId",
                table: "Wallets",
                column: "CargoId",
                principalTable: "Cargoes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_CompanionInsurancePackageSales_CompanionInsurancePackageSaleId",
                table: "Wallets",
                column: "CompanionInsurancePackageSaleId",
                principalTable: "CompanionInsurancePackageSales",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_CompanionReserves_CompanionReserveId",
                table: "Wallets",
                column: "CompanionReserveId",
                principalTable: "CompanionReserves",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Trips_TripId",
                table: "Wallets",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Cargoes_CargoId",
                table: "Wallets");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_CompanionInsurancePackageSales_CompanionInsurancePackageSaleId",
                table: "Wallets");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_CompanionReserves_CompanionReserveId",
                table: "Wallets");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Trips_TripId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_CargoId",
                table: "Wallets");

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
                name: "CargoId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "CompanionInsurancePackageSaleId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "CompanionReserveId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "WalletPrice",
                table: "Cargoes");
        }
    }
}
