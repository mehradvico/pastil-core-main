using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_trip234234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Cities_FromCityId",
                table: "Trips");

            migrationBuilder.AlterColumn<long>(
                name: "FromCityId",
                table: "Trips",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "ConnectionId",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserToken",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "StopPrice",
                table: "PriceCalculations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Cities_FromCityId",
                table: "Trips",
                column: "FromCityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Cities_FromCityId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "ConnectionId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UserToken",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "StopPrice",
                table: "PriceCalculations");

            migrationBuilder.AlterColumn<long>(
                name: "FromCityId",
                table: "Trips",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Cities_FromCityId",
                table: "Trips",
                column: "FromCityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
