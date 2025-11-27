using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_ChangeObjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUsItem_ContactUses_ContactUsId",
                table: "ContactUsItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactUsItem",
                table: "ContactUsItem");

            migrationBuilder.RenameTable(
                name: "ContactUsItem",
                newName: "ContactUsItems");

            migrationBuilder.RenameIndex(
                name: "IX_ContactUsItem_ContactUsId",
                table: "ContactUsItems",
                newName: "IX_ContactUsItems_ContactUsId");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Companions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactUsItems",
                table: "ContactUsItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Codes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_TypeId",
                table: "Notifications",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUsItems_ContactUses_ContactUsId",
                table: "ContactUsItems",
                column: "ContactUsId",
                principalTable: "ContactUses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactUsItems_ContactUses_ContactUsId",
                table: "ContactUsItems");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactUsItems",
                table: "ContactUsItems");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Companions");

            migrationBuilder.RenameTable(
                name: "ContactUsItems",
                newName: "ContactUsItem");

            migrationBuilder.RenameIndex(
                name: "IX_ContactUsItems_ContactUsId",
                table: "ContactUsItem",
                newName: "IX_ContactUsItem_ContactUsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactUsItem",
                table: "ContactUsItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactUsItem_ContactUses_ContactUsId",
                table: "ContactUsItem",
                column: "ContactUsId",
                principalTable: "ContactUses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
