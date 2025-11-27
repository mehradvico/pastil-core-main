using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_DriveDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Companions_DriverId",
                table: "Trips");

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    ProfilePictureId = table.Column<long>(type: "bigint", nullable: true),
                    CertificatePictureId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleCardPictureId = table.Column<long>(type: "bigint", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    NeighborhoodId = table.Column<long>(type: "bigint", nullable: true),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Driver_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Driver_Codes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Codes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Driver_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Driver_Pictures_CertificatePictureId",
                        column: x => x.CertificatePictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Driver_Pictures_ProfilePictureId",
                        column: x => x.ProfilePictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Driver_Pictures_VehicleCardPictureId",
                        column: x => x.VehicleCardPictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Driver_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Driver_CertificatePictureId",
                table: "Driver",
                column: "CertificatePictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_CityId",
                table: "Driver",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_NeighborhoodId",
                table: "Driver",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_OwnerId",
                table: "Driver",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_ProfilePictureId",
                table: "Driver",
                column: "ProfilePictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_TypeId",
                table: "Driver",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_VehicleCardPictureId",
                table: "Driver",
                column: "VehicleCardPictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Driver_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Driver_DriverId",
                table: "Trips");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Companions_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Companions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
