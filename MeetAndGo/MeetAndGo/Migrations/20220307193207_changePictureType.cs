using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetAndGo.Migrations
{
    public partial class changePictureType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfBuilding",
                columns: table => new
                {
                    TypeOfBuildingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfBuilding", x => x.TypeOfBuildingId);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfOffice",
                columns: table => new
                {
                    TypeOfOfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfOffice", x => x.TypeOfOfficeId);
                });

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    UserAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 100, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.UserAccountId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "Fk_Country_City_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    UserAccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "Fk_UserAccount_User_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccount",
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAccountRole",
                columns: table => new
                {
                    UserAccountRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    UserAccountId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccountRole", x => x.UserAccountRoleId);
                    table.ForeignKey(
                        name: "Fk_Role_UserAccountRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_UserAccount_UserAccountRole_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccount",
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Area = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Picture = table.Column<byte[]>(maxLength: 2000, nullable: false),
                    Rented = table.Column<bool>(nullable: false),
                    NumberOfFloors = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    TypeOfBuildingId = table.Column<int>(nullable: false),
                    NumberOfOffices = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false),
                    Security = table.Column<bool>(nullable: false),
                    Cameras = table.Column<bool>(nullable: false),
                    Parking = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingId);
                    table.ForeignKey(
                        name: "Fk_City_Building_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_TypeOfBuilding_Building_TypeOfBuildingId",
                        column: x => x.TypeOfBuildingId,
                        principalTable: "TypeOfBuilding",
                        principalColumn: "TypeOfBuildingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Area = table.Column<string>(maxLength: 50, nullable: false),
                    Picture = table.Column<byte[]>(maxLength: 2000, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Rented = table.Column<bool>(nullable: false),
                    NumberOfFloors = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    TypeOfOfficeId = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false),
                    Parking = table.Column<bool>(nullable: false),
                    Cameras = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeId);
                    table.ForeignKey(
                        name: "Fk_City_Office_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_TypeOfOffice_Office_TypeOfOfficeId",
                        column: x => x.TypeOfOfficeId,
                        principalTable: "TypeOfOffice",
                        principalColumn: "TypeOfOfficeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_Transactions_TransactionIdUserId", x => new { x.TransactionId, x.UserId });
                    table.ForeignKey(
                        name: "Fk_User_Transactions_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingReview",
                columns: table => new
                {
                    BuildingReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                    Mark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_BuildingReview_BuildingReviewIdUserIdBuildingId", x => new { x.BuildingReviewId, x.UserId, x.BuildingId });
                    table.ForeignKey(
                        name: "Fk_Building_BuildingReview_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_User_BuildingReview_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CanceledBuilding",
                columns: table => new
                {
                    CanceledBuildingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                    CancelDate = table.Column<DateTime>(nullable: false),
                    Fee = table.Column<bool>(nullable: false),
                    FeePrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanceledBuilding", x => x.CanceledBuildingId);
                    table.ForeignKey(
                        name: "Fk_Building_CanceledBuilding_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_User_CanceledBuilding_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentedBuilding",
                columns: table => new
                {
                    RentedBuildingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    BeginRentalDate = table.Column<DateTime>(nullable: false),
                    EndRentalDate = table.Column<DateTime>(nullable: false),
                    Rented = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_RentedBuilding_RentedBuildingIdBuildingIdUserId", x => new { x.RentedBuildingId, x.BuildingId, x.UserId });
                    table.ForeignKey(
                        name: "Fk_Building_RentedBuilding_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_User_RentedBuilding_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CanceledOffice",
                columns: table => new
                {
                    CanceledOfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CancelDate = table.Column<DateTime>(nullable: false),
                    Fee = table.Column<bool>(nullable: false),
                    FeePrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_CanceledOffice_CanceledOfficeIdOfficeIdUserId", x => new { x.CanceledOfficeId, x.OfficeId, x.UserId });
                    table.ForeignKey(
                        name: "Fk_Office_CanceledOffice_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_User_CanceledOffice_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfficeReview",
                columns: table => new
                {
                    OfficeReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    OfficeId = table.Column<int>(nullable: false),
                    Mark = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_OfficeReview_OfficeReviewIdUserIdOfficeId", x => new { x.OfficeReviewId, x.UserId, x.OfficeId });
                    table.ForeignKey(
                        name: "Fk_Office_OfficeReview_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_User_OfficeReview_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentedOffice",
                columns: table => new
                {
                    RentedOfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    BeginRentalDate = table.Column<DateTime>(nullable: false),
                    EndRentalDate = table.Column<DateTime>(nullable: false),
                    Rented = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_RentedOffice_RentedOfficeIdOfficeId", x => new { x.RentedOfficeId, x.OfficeId });
                    table.ForeignKey(
                        name: "Fk_Office_RentedOffice_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Fk_User_RentedOffice_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Building_CityId",
                table: "Building",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_TypeOfBuildingId",
                table: "Building",
                column: "TypeOfBuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingReview_BuildingId",
                table: "BuildingReview",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingReview_UserId",
                table: "BuildingReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CanceledBuilding_BuildingId",
                table: "CanceledBuilding",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_CanceledBuilding_UserId",
                table: "CanceledBuilding",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CanceledOffice_OfficeId",
                table: "CanceledOffice",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_CanceledOffice_UserId",
                table: "CanceledOffice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_CityId",
                table: "Office",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_TypeOfOfficeId",
                table: "Office",
                column: "TypeOfOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeReview_OfficeId",
                table: "OfficeReview",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeReview_UserId",
                table: "OfficeReview",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedBuilding_BuildingId",
                table: "RentedBuilding",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedBuilding_UserId",
                table: "RentedBuilding",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedOffice_OfficeId",
                table: "RentedOffice",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedOffice_UserId",
                table: "RentedOffice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAccountId",
                table: "User",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccountRole_RoleId",
                table: "UserAccountRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccountRole_UserAccountId",
                table: "UserAccountRole",
                column: "UserAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingReview");

            migrationBuilder.DropTable(
                name: "CanceledBuilding");

            migrationBuilder.DropTable(
                name: "CanceledOffice");

            migrationBuilder.DropTable(
                name: "OfficeReview");

            migrationBuilder.DropTable(
                name: "RentedBuilding");

            migrationBuilder.DropTable(
                name: "RentedOffice");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserAccountRole");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "TypeOfBuilding");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "TypeOfOffice");

            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
