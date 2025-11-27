using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using System;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_Companion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Clinics");

            migrationBuilder.CreateTable(
                name: "Companions",
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
                    table.PrimaryKey("PK_Companions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companions_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companions_Pictures_IconId",
                        column: x => x.IconId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companions_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companions_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionAssistances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanionId = table.Column<long>(type: "bigint", nullable: false),
                    AssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    PrePaymentPrice = table.Column<double>(type: "float", nullable: false),
                    IsSinglePackage = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionAssistances_Assistances_AssistanceId",
                        column: x => x.AssistanceId,
                        principalTable: "Assistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionAssistances_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionAssistancePackages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CompanionAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistancePackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionAssistancePackages_CompanionAssistances_CompanionAssistanceId",
                        column: x => x.CompanionAssistanceId,
                        principalTable: "CompanionAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionAssistanceTimes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekDayId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionAssistanceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistanceTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionAssistanceTimes_CompanionAssistances_CompanionAssistanceId",
                        column: x => x.CompanionAssistanceId,
                        principalTable: "CompanionAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionAssistanceTimes_WeekDays_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "WeekDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionAssistanceUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionAssistanceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistanceUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionAssistanceUsers_CompanionAssistances_CompanionAssistanceId",
                        column: x => x.CompanionAssistanceId,
                        principalTable: "CompanionAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionAssistanceUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanionReserves",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookerId = table.Column<long>(type: "bigint", nullable: false),
                    UserPetId = table.Column<long>(type: "bigint", nullable: false),
                    PrePaymentPrice = table.Column<double>(type: "float", nullable: false),
                    FinalPrice = table.Column<double>(type: "float", nullable: true),
                    PackagePrice = table.Column<double>(type: "float", nullable: false),
                    CompanionAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionAssistanceTimeId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsFemale = table.Column<bool>(type: "bit", nullable: true),
                    BookerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssistanceDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionReserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanionReserves_CompanionAssistanceTimes_CompanionAssistanceTimeId",
                        column: x => x.CompanionAssistanceTimeId,
                        principalTable: "CompanionAssistanceTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReserves_CompanionAssistances_CompanionAssistanceId",
                        column: x => x.CompanionAssistanceId,
                        principalTable: "CompanionAssistances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReserves_UserPets_UserPetId",
                        column: x => x.UserPetId,
                        principalTable: "UserPets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReserves_Users_BookerId",
                        column: x => x.BookerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionReserves_Users_CompanionUserId",
                        column: x => x.CompanionUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanionAssistancePackageCompanionReserve",
                columns: table => new
                {
                    CompanionAssistancePackagesId = table.Column<long>(type: "bigint", nullable: false),
                    CompanionReservesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionAssistancePackageCompanionReserve", x => new { x.CompanionAssistancePackagesId, x.CompanionReservesId });
                    table.ForeignKey(
                        name: "FK_CompanionAssistancePackageCompanionReserve_CompanionAssistancePackages_CompanionAssistancePackagesId",
                        column: x => x.CompanionAssistancePackagesId,
                        principalTable: "CompanionAssistancePackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanionAssistancePackageCompanionReserve_CompanionReserves_CompanionReservesId",
                        column: x => x.CompanionReservesId,
                        principalTable: "CompanionReserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistancePackageCompanionReserve_CompanionReservesId",
                table: "CompanionAssistancePackageCompanionReserve",
                column: "CompanionReservesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistancePackages_CompanionAssistanceId",
                table: "CompanionAssistancePackages",
                column: "CompanionAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistances_AssistanceId",
                table: "CompanionAssistances",
                column: "AssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistances_CompanionId",
                table: "CompanionAssistances",
                column: "CompanionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistanceTimes_CompanionAssistanceId",
                table: "CompanionAssistanceTimes",
                column: "CompanionAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistanceTimes_WeekDayId",
                table: "CompanionAssistanceTimes",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistanceUsers_CompanionAssistanceId",
                table: "CompanionAssistanceUsers",
                column: "CompanionAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionAssistanceUsers_UserId",
                table: "CompanionAssistanceUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_BookerId",
                table: "CompanionReserves",
                column: "BookerId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_CompanionAssistanceId",
                table: "CompanionReserves",
                column: "CompanionAssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_CompanionAssistanceTimeId",
                table: "CompanionReserves",
                column: "CompanionAssistanceTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_CompanionUserId",
                table: "CompanionReserves",
                column: "CompanionUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanionReserves_UserPetId",
                table: "CompanionReserves",
                column: "UserPetId");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_CityId",
                table: "Companions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_IconId",
                table: "Companions",
                column: "IconId");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_NeighborhoodId",
                table: "Companions",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_OwnerId",
                table: "Companions",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Companions_PictureId",
                table: "Companions",
                column: "PictureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionAssistancePackageCompanionReserve");

            migrationBuilder.DropTable(
                name: "CompanionAssistanceUsers");

            migrationBuilder.DropTable(
                name: "CompanionAssistancePackages");

            migrationBuilder.DropTable(
                name: "CompanionReserves");

            migrationBuilder.DropTable(
                name: "CompanionAssistanceTimes");

            migrationBuilder.DropTable(
                name: "CompanionAssistances");

            migrationBuilder.DropTable(
                name: "Companions");

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    IconId = table.Column<long>(type: "bigint", nullable: true),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    PictureId = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    AddressValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPersonal = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<Point>(type: "geography", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoCanonical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoH1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoMinDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoNoFollow = table.Column<bool>(type: "bit", nullable: false),
                    SeoNoIndex = table.Column<bool>(type: "bit", nullable: false),
                    SeoPictureAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoUrlText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    AssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    IsSinglePackage = table.Column<bool>(type: "bit", nullable: false),
                    PrePaymentPrice = table.Column<double>(type: "float", nullable: false)
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
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
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
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    WeekDayId = table.Column<long>(type: "bigint", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
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
                    ClinicAssistanceId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicAssistanceTimeId = table.Column<long>(type: "bigint", nullable: false),
                    ClinicUserId = table.Column<long>(type: "bigint", nullable: true),
                    UserPetId = table.Column<long>(type: "bigint", nullable: false),
                    AssistanceDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalPrice = table.Column<double>(type: "float", nullable: true),
                    IsFemale = table.Column<bool>(type: "bit", nullable: true),
                    PackagePrice = table.Column<double>(type: "float", nullable: false),
                    PrePaymentPrice = table.Column<double>(type: "float", nullable: false)
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
        }
    }
}
