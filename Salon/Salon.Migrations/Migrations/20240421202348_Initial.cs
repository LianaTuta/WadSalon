using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salon.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Salon_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserLoginId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserLoginId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appoinment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserLoginId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    AppoinmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appoinment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appoinment_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appoinment_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Salon",
                columns: new[] { "Id", "Address", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, "Address 1", "Description 1", "salon1.jpg", "Beauty Salon 1" },
                    { 2, "Address 2", "Description 2", "salon1.jpg", "Beauty Salon 2" },
                    { 3, "Address 3", "Description 3", "salon1.jpg", "Beauty Salon 3" },
                    { 4, "Address 4", "Description 4", "salon1.jpg", "Beauty Salon 4" }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Description", "Name", "SalonId" },
                values: new object[,]
                {
                    { 1, "Description nails", "Gel Nails", 1 },
                    { 2, "Descriptions hair", "Hair Treatment", 1 },
                    { 3, "Description hair", "Haircut", 1 },
                    { 4, "Description facials", "Gel Nails", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appoinment_ServiceId",
                table: "Appoinment",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appoinment_UserLoginId",
                table: "Appoinment",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_SalonId",
                table: "Service",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserLoginId",
                table: "UserAddress",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserLoginId",
                table: "UserProfile",
                column: "UserLoginId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appoinment");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "Salon");
        }
    }
}
