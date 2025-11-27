using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigStoreComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreComment_Comments_Id",
                table: "StoreComment");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreComment_Stores_StoreId",
                table: "StoreComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreComment",
                table: "StoreComment");

            migrationBuilder.RenameTable(
                name: "StoreComment",
                newName: "StoreComments");

            migrationBuilder.RenameIndex(
                name: "IX_StoreComment_StoreId",
                table: "StoreComments",
                newName: "IX_StoreComments_StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreComments",
                table: "StoreComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreComments_Comments_Id",
                table: "StoreComments",
                column: "Id",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreComments_Stores_StoreId",
                table: "StoreComments",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreComments_Comments_Id",
                table: "StoreComments");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreComments_Stores_StoreId",
                table: "StoreComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreComments",
                table: "StoreComments");

            migrationBuilder.RenameTable(
                name: "StoreComments",
                newName: "StoreComment");

            migrationBuilder.RenameIndex(
                name: "IX_StoreComments_StoreId",
                table: "StoreComment",
                newName: "IX_StoreComment_StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreComment",
                table: "StoreComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreComment_Comments_Id",
                table: "StoreComment",
                column: "Id",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreComment_Stores_StoreId",
                table: "StoreComment",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
