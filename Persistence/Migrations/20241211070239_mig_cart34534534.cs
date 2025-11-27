using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_cart34534534 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancelRequestDate",
                table: "ProductOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChildOrderId",
                table: "ProductOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentOrderId",
                table: "ProductOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReserveDate",
                table: "ProductOrders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentOrderId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Reserve",
                table: "Carts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelRequestDate",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "ChildOrderId",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "ParentOrderId",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "ReserveDate",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "ParentOrderId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Reserve",
                table: "Carts");
        }
    }
}
