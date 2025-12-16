using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_pansionreserve1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PansionReserves_Wallets_WalletId",
                table: "PansionReserves");

            migrationBuilder.DropIndex(
                name: "IX_PansionReserves_WalletId",
                table: "PansionReserves");

            migrationBuilder.DropColumn(
                name: "WalletId",
                table: "PansionReserves");

            migrationBuilder.DropColumn(
                name: "FromDate",
                table: "CompanionReserves");

            migrationBuilder.DropColumn(
                name: "ToDate",
                table: "CompanionReserves");

            migrationBuilder.AddColumn<long>(
                name: "PansionReserveId",
                table: "Wallets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PansionId",
                table: "PansionReserves",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_PansionReserveId",
                table: "Wallets",
                column: "PansionReserveId",
                unique: true,
                filter: "[PansionReserveId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_PansionId",
                table: "PansionReserves",
                column: "PansionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PansionReserves_Pansions_PansionId",
                table: "PansionReserves",
                column: "PansionId",
                principalTable: "Pansions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_PansionReserves_PansionReserveId",
                table: "Wallets",
                column: "PansionReserveId",
                principalTable: "PansionReserves",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PansionReserves_Pansions_PansionId",
                table: "PansionReserves");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_PansionReserves_PansionReserveId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_PansionReserveId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_PansionReserves_PansionId",
                table: "PansionReserves");

            migrationBuilder.DropColumn(
                name: "PansionReserveId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "PansionId",
                table: "PansionReserves");

            migrationBuilder.AddColumn<long>(
                name: "WalletId",
                table: "PansionReserves",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FromDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ToDate",
                table: "CompanionReserves",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_WalletId",
                table: "PansionReserves",
                column: "WalletId");

            migrationBuilder.AddForeignKey(
                name: "FK_PansionReserves_Wallets_WalletId",
                table: "PansionReserves",
                column: "WalletId",
                principalTable: "Wallets",
                principalColumn: "Id");
        }
    }
}
