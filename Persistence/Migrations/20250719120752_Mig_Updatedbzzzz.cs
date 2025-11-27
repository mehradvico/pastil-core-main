using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Updatedbzzzz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Cargoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaymentPrice",
                table: "Cargoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "RebateId",
                table: "Cargoes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RebatePrice",
                table: "Cargoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Cargoes_RebateId",
                table: "Cargoes",
                column: "RebateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargoes_Rebate_RebateId",
                table: "Cargoes",
                column: "RebateId",
                principalTable: "Rebate",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargoes_Rebate_RebateId",
                table: "Cargoes");

            migrationBuilder.DropIndex(
                name: "IX_Cargoes_RebateId",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "PaymentPrice",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "RebateId",
                table: "Cargoes");

            migrationBuilder.DropColumn(
                name: "RebatePrice",
                table: "Cargoes");
        }
    }
}
