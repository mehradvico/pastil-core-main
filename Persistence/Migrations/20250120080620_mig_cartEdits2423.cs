using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_cartEdits2423 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            //migrationBuilder.DropIndex(
            //    name: "IX_CartItems_CartId",
            //    table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ParentOrderId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Reserve",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartItems");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "UserProducts",
                type: "float",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "AdminDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StoreId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeliveryId",
                table: "ProductOrderStores",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DeliveryPrice",
                table: "ProductOrderStores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaymentPrice",
                table: "ProductOrderStores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "AfterRent",
                table: "Deliveries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MinCountForFree",
                table: "Deliveries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CartStores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeliveryId",
                table: "CartStores",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DeliveryPrice",
                table: "CartStores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PaymentPrice",
                table: "CartStores",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoreId",
                table: "Products",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrderStores_DeliveryId",
                table: "ProductOrderStores",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_CartStores_DeliveryId",
                table: "CartStores",
                column: "DeliveryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartStores_Deliveries_DeliveryId",
                table: "CartStores",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrderStores_Deliveries_DeliveryId",
                table: "ProductOrderStores",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Stores_StoreId",
                table: "Products",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartStores_Deliveries_DeliveryId",
                table: "CartStores");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrderStores_Deliveries_DeliveryId",
                table: "ProductOrderStores");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Stores_StoreId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StoreId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductOrderStores_DeliveryId",
                table: "ProductOrderStores");

            migrationBuilder.DropIndex(
                name: "IX_CartStores_DeliveryId",
                table: "CartStores");

            migrationBuilder.DropColumn(
                name: "AdminDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "ProductOrderStores");

            migrationBuilder.DropColumn(
                name: "DeliveryPrice",
                table: "ProductOrderStores");

            migrationBuilder.DropColumn(
                name: "PaymentPrice",
                table: "ProductOrderStores");

            migrationBuilder.DropColumn(
                name: "AfterRent",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "MinCountForFree",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "CartStores");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "CartStores");

            migrationBuilder.DropColumn(
                name: "DeliveryPrice",
                table: "CartStores");

            migrationBuilder.DropColumn(
                name: "PaymentPrice",
                table: "CartStores");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "UserProducts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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

            migrationBuilder.AddColumn<long>(
                name: "CartId",
                table: "CartItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }
    }
}
