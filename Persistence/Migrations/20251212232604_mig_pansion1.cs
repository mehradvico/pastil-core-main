using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_pansion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PansionReserves",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookerId = table.Column<long>(type: "bigint", nullable: false),
                    UserPetId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FromWallet = table.Column<bool>(type: "bit", nullable: false),
                    WalletPrice = table.Column<double>(type: "float", nullable: false),
                    PaymentPrice = table.Column<double>(type: "float", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    CancelDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    RebateId = table.Column<long>(type: "bigint", nullable: true),
                    RebatePrice = table.Column<double>(type: "float", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionShare = table.Column<double>(type: "float", nullable: false),
                    SiteShare = table.Column<double>(type: "float", nullable: false),
                    WalletId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PansionReserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PansionReserves_Codes_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PansionReserves_Rebate_RebateId",
                        column: x => x.RebateId,
                        principalTable: "Rebate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PansionReserves_UserPets_UserPetId",
                        column: x => x.UserPetId,
                        principalTable: "UserPets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PansionReserves_Users_BookerId",
                        column: x => x.BookerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PansionReserves_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pansions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSchool = table.Column<bool>(type: "bit", nullable: false),
                    CompanionId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Approve = table.Column<bool>(type: "bit", nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    RateAvg = table.Column<double>(type: "float", nullable: false),
                    RateCount = table.Column<int>(type: "int", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: true),
                    Suggested = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Regulations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloseHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pansions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pansions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pansions_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pansions_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pansions_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PansionComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PansionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PansionComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PansionComments_Comments_Id",
                        column: x => x.Id,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PansionComments_Pansions_PansionId",
                        column: x => x.PansionId,
                        principalTable: "Pansions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PansionPets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PansionId = table.Column<long>(type: "bigint", nullable: false),
                    PetId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PansionPets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PansionPets_Pansions_PansionId",
                        column: x => x.PansionId,
                        principalTable: "Pansions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PansionPets_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PansionPictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PansionId = table.Column<long>(type: "bigint", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PansionPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PansionPictures_Pansions_PansionId",
                        column: x => x.PansionId,
                        principalTable: "Pansions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PansionPictures_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PansionComments_PansionId",
                table: "PansionComments",
                column: "PansionId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionPets_PansionId",
                table: "PansionPets",
                column: "PansionId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionPets_PetId",
                table: "PansionPets",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionPictures_PansionId",
                table: "PansionPictures",
                column: "PansionId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionPictures_PictureId",
                table: "PansionPictures",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_BookerId",
                table: "PansionReserves",
                column: "BookerId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_RebateId",
                table: "PansionReserves",
                column: "RebateId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_StatusId",
                table: "PansionReserves",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_UserPetId",
                table: "PansionReserves",
                column: "UserPetId");

            migrationBuilder.CreateIndex(
                name: "IX_PansionReserves_WalletId",
                table: "PansionReserves",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Pansions_CityId",
                table: "Pansions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pansions_CompanionId",
                table: "Pansions",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pansions_PictureId",
                table: "Pansions",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Pansions_StateId",
                table: "Pansions",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PansionComments");

            migrationBuilder.DropTable(
                name: "PansionPets");

            migrationBuilder.DropTable(
                name: "PansionPictures");

            migrationBuilder.DropTable(
                name: "PansionReserves");

            migrationBuilder.DropTable(
                name: "Pansions");
        }
    }
}
