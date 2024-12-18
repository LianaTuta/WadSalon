using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salon.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_UserLogin_UserLoginId",
                table: "UserProfile");

            migrationBuilder.DropIndex(
                name: "IX_UserProfile_UserLoginId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "UserProfile");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserId",
                table: "UserProfile",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_AspNetUserId",
                table: "UserProfile",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_AspNetUsers_AspNetUserId",
                table: "UserProfile",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_AspNetUsers_AspNetUserId",
                table: "UserProfile");

            migrationBuilder.DropIndex(
                name: "IX_UserProfile_AspNetUserId",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "UserProfile");

            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "UserProfile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserLoginId",
                table: "UserProfile",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_UserLogin_UserLoginId",
                table: "UserProfile",
                column: "UserLoginId",
                principalTable: "UserLogin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
