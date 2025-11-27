using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Clinic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClickBuyerCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClickGuid",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "IsFemale",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "NeighborhoodId",
                table: "NameFieldLangs",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assistances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPersonal = table.Column<bool>(type: "bit", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assistances_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionNumber = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Neighborhoods_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPersonal = table.Column<bool>(type: "bit", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: true),
                    IconId = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    AddressValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<Point>(type: "geography", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoH1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoMinDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoPictureAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoUrlText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoNoIndex = table.Column<bool>(type: "bit", nullable: false),
                    SeoNoFollow = table.Column<bool>(type: "bit", nullable: false),
                    SeoCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clinics_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clinics_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clinics_Pictures_IconId",
                        column: x => x.IconId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clinics_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clinics_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicAssistances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicId = table.Column<long>(type: "bigint", nullable: false),
                    AssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    PrePaymentPrice = table.Column<double>(type: "float", nullable: false),
                    IsSinglePackage = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicAssistances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicAssistances_Assistances_AssistanceId",
                        column: x => x.AssistanceId,
                        principalTable: "Assistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicAssistances_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicAssistancePackages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicAssistancePackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicAssistancePackages_ClinicAssistances_ClinicAssistanceId",
                        column: x => x.ClinicAssistanceId,
                        principalTable: "ClinicAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicAssistanceTimes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekDayId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicAssistanceTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicAssistanceTimes_ClinicAssistances_ClinicAssistanceId",
                        column: x => x.ClinicAssistanceId,
                        principalTable: "ClinicAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicAssistanceTimes_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "WeekDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicAssistanceUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicAssistanceUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicAssistanceUsers_ClinicAssistances_ClinicAssistanceId",
                        column: x => x.ClinicAssistanceId,
                        principalTable: "ClinicAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicAssistanceUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicReserves",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookerId = table.Column<long>(type: "bigint", nullable: false),
                    UserPetId = table.Column<long>(type: "bigint", nullable: false),
                    PrePaymentPrice = table.Column<double>(type: "float", nullable: false),
                    FinalPrice = table.Column<double>(type: "float", nullable: true),
                    PackagePrice = table.Column<double>(type: "float", nullable: false),
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicAssistanceTimeId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsFemale = table.Column<bool>(type: "bit", nullable: true),
                    BookerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssistanceDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicReserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicReserves_ClinicAssistanceTimes_ClinicAssistanceTimeId",
                        column: x => x.ClinicAssistanceTimeId,
                        principalTable: "ClinicAssistanceTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicReserves_ClinicAssistances_ClinicAssistanceId",
                        column: x => x.ClinicAssistanceId,
                        principalTable: "ClinicAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicReserves_UserPets_UserPetId",
                        column: x => x.UserPetId,
                        principalTable: "UserPets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicReserves_Users_BookerId",
                        column: x => x.BookerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicReserves_Users_ClinicUserId",
                        column: x => x.ClinicUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClinicAssistancePackageClinicReserve",
                columns: table => new
                {
                    ClinicAssistancePackagesId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicReservesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicAssistancePackageClinicReserve", x => new { x.ClinicAssistancePackagesId, x.ClinicReservesId });
                    table.ForeignKey(
                        name: "FK_ClinicAssistancePackageClinicReserve_ClinicAssistancePackages_ClinicAssistancePackagesId",
                        column: x => x.ClinicAssistancePackagesId,
                        principalTable: "ClinicAssistancePackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClinicAssistancePackageClinicReserve_ClinicReserves_ClinicReservesId",
                        column: x => x.ClinicReservesId,
                        principalTable: "ClinicReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NameFieldLangs_NeighborhoodId",
                table: "NameFieldLangs",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Assistances_PictureId",
                table: "Assistances",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistancePackageClinicReserve_ClinicReservesId",
                table: "ClinicAssistancePackageClinicReserve",
                column: "ClinicReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistancePackages_ClinicAssistanceId",
                table: "ClinicAssistancePackages",
                column: "ClinicAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistances_AssistanceId",
                table: "ClinicAssistances",
                column: "AssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistances_ClinicId",
                table: "ClinicAssistances",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistanceTimes_ClinicAssistanceId",
                table: "ClinicAssistanceTimes",
                column: "ClinicAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistanceTimes_WeekDayId",
                table: "ClinicAssistanceTimes",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistanceUsers_ClinicAssistanceId",
                table: "ClinicAssistanceUsers",
                column: "ClinicAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAssistanceUsers_UserId",
                table: "ClinicAssistanceUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicReserves_BookerId",
                table: "ClinicReserves",
                column: "BookerId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicReserves_ClinicAssistanceId",
                table: "ClinicReserves",
                column: "ClinicAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicReserves_ClinicAssistanceTimeId",
                table: "ClinicReserves",
                column: "ClinicAssistanceTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicReserves_ClinicUserId",
                table: "ClinicReserves",
                column: "ClinicUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicReserves_UserPetId",
                table: "ClinicReserves",
                column: "UserPetId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_CityId",
                table: "Clinics",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_IconId",
                table: "Clinics",
                column: "IconId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_NeighborhoodId",
                table: "Clinics",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_OwnerId",
                table: "Clinics",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_PictureId",
                table: "Clinics",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhoods_CityId",
                table: "Neighborhoods",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_NameFieldLangs_Neighborhoods_NeighborhoodId",
                table: "NameFieldLangs",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NameFieldLangs_Neighborhoods_NeighborhoodId",
                table: "NameFieldLangs");

            migrationBuilder.DropTable(
                name: "ClinicAssistancePackageClinicReserve");

            migrationBuilder.DropTable(
                name: "ClinicAssistanceUsers");

            migrationBuilder.DropTable(
                name: "ClinicAssistancePackages");

            migrationBuilder.DropTable(
                name: "ClinicReserves");

            migrationBuilder.DropTable(
                name: "ClinicAssistanceTimes");

            migrationBuilder.DropTable(
                name: "ClinicAssistances");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "Assistances");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropIndex(
                name: "IX_NameFieldLangs_NeighborhoodId",
                table: "NameFieldLangs");

            migrationBuilder.DropColumn(
                name: "IsFemale",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NeighborhoodId",
                table: "NameFieldLangs");

            migrationBuilder.AddColumn<string>(
                name: "ClickBuyerCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClickGuid",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
