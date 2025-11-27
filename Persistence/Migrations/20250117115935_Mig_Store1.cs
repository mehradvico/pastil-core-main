using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Store1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentCount",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Warranty",
                table: "Stores",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DownThumb",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpThumb",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoreComment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreComment_Comments_Id",
                        column: x => x.Id,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreComment_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreComment_StoreId",
                table: "StoreComment",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreComment");

            migrationBuilder.DropColumn(
                name: "CommentCount",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Warranty",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "DownThumb",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UpThumb",
                table: "Comments");
        }
    }
}
