using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salon.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appoinment_UserLogin_UserLoginId",
                table: "Appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_UserLogin_UserLoginId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_UserAddress_UserLoginId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_Appoinment_UserLoginId",
                table: "Appoinment");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "Appoinment");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "UserAddress",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "Appoinment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_AspNetUserId",
                table: "UserAddress",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appoinment_AspNetUserId",
                table: "Appoinment",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_AspNetUsers_AspNetUserId",
                table: "Appoinment",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_AspNetUsers_AspNetUserId",
                table: "UserAddress",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appoinment_AspNetUsers_AspNetUserId",
                table: "Appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_AspNetUsers_AspNetUserId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_UserAddress_AspNetUserId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_Appoinment_AspNetUserId",
                table: "Appoinment");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "Appoinment");

            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "UserAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "Appoinment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserLoginId",
                table: "UserAddress",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Appoinment_UserLoginId",
                table: "Appoinment",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_UserLogin_UserLoginId",
                table: "Appoinment",
                column: "UserLoginId",
                principalTable: "UserLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_UserLogin_UserLoginId",
                table: "UserAddress",
                column: "UserLoginId",
                principalTable: "UserLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
