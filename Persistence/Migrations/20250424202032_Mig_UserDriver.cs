using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig_UserDriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Cities_CityId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Codes_StatusId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Neighborhoods_NeighborhoodId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Pictures_CertificatePictureId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Pictures_ProfilePictureId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Pictures_VehicleCardPictureId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Users_OwnerId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Driver_DriverId",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Driver_OwnerId",
                table: "Driver");

            migrationBuilder.RenameTable(
                name: "Driver",
                newName: "Drivers");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_VehicleCardPictureId",
                table: "Drivers",
                newName: "IX_Drivers_VehicleCardPictureId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_StatusId",
                table: "Drivers",
                newName: "IX_Drivers_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_ProfilePictureId",
                table: "Drivers",
                newName: "IX_Drivers_ProfilePictureId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_NeighborhoodId",
                table: "Drivers",
                newName: "IX_Drivers_NeighborhoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_CityId",
                table: "Drivers",
                newName: "IX_Drivers_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_CertificatePictureId",
                table: "Drivers",
                newName: "IX_Drivers_CertificatePictureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_OwnerId",
                table: "Drivers",
                column: "OwnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Cities_CityId",
                table: "Drivers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Codes_StatusId",
                table: "Drivers",
                column: "StatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Neighborhoods_NeighborhoodId",
                table: "Drivers",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Pictures_CertificatePictureId",
                table: "Drivers",
                column: "CertificatePictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Pictures_ProfilePictureId",
                table: "Drivers",
                column: "ProfilePictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Pictures_VehicleCardPictureId",
                table: "Drivers",
                column: "VehicleCardPictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Users_OwnerId",
                table: "Drivers",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Drivers_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Cities_CityId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Codes_StatusId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Neighborhoods_NeighborhoodId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Pictures_CertificatePictureId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Pictures_ProfilePictureId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Pictures_VehicleCardPictureId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Users_OwnerId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Drivers_DriverId",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_OwnerId",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "Driver");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_VehicleCardPictureId",
                table: "Driver",
                newName: "IX_Driver_VehicleCardPictureId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_StatusId",
                table: "Driver",
                newName: "IX_Driver_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_ProfilePictureId",
                table: "Driver",
                newName: "IX_Driver_ProfilePictureId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_NeighborhoodId",
                table: "Driver",
                newName: "IX_Driver_NeighborhoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_CityId",
                table: "Driver",
                newName: "IX_Driver_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_CertificatePictureId",
                table: "Driver",
                newName: "IX_Driver_CertificatePictureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_OwnerId",
                table: "Driver",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Cities_CityId",
                table: "Driver",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Codes_StatusId",
                table: "Driver",
                column: "StatusId",
                principalTable: "Codes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Neighborhoods_NeighborhoodId",
                table: "Driver",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Pictures_CertificatePictureId",
                table: "Driver",
                column: "CertificatePictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Pictures_ProfilePictureId",
                table: "Driver",
                column: "ProfilePictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Pictures_VehicleCardPictureId",
                table: "Driver",
                column: "VehicleCardPictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Users_OwnerId",
                table: "Driver",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Driver_DriverId",
                table: "Trips",
                column: "DriverId",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
