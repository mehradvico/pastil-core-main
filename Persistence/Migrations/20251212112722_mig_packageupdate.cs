using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_packageupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "CompanionAssistancePackages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PictureId",
                table: "CompanionAssistancePackages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PrePaymentPrice",
                table: "CompanionAssistancePackages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "CompanionAssistancePackagePictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionAssistancePackageId = table.Column<long>(type: "bigint", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistancePackagePictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionAssistancePackagePictures_CompanionAssistancePackages_CompanionAssistancePackageId",
                        column: x => x.CompanionAssistancePackageId,
                        principalTable: "CompanionAssistancePackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionAssistancePackagePictures_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistancePackages_PictureId",
                table: "CompanionAssistancePackages",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistancePackagePictures_CompanionAssistancePackageId",
                table: "CompanionAssistancePackagePictures",
                column: "CompanionAssistancePackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistancePackagePictures_PictureId",
                table: "CompanionAssistancePackagePictures",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanionAssistancePackages_Pictures_PictureId",
                table: "CompanionAssistancePackages",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanionAssistancePackages_Pictures_PictureId",
                table: "CompanionAssistancePackages");

            migrationBuilder.DropTable(
                name: "CompanionAssistancePackagePictures");

            migrationBuilder.DropIndex(
                name: "IX_CompanionAssistancePackages_PictureId",
                table: "CompanionAssistancePackages");

            migrationBuilder.DropColumn(
                name: "Discription",
                table: "CompanionAssistancePackages");

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "CompanionAssistancePackages");

            migrationBuilder.DropColumn(
                name: "PrePaymentPrice",
                table: "CompanionAssistancePackages");
        }
    }
}
