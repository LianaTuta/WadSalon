using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salon.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Welcome to Serene Haven Salon & Spa, where tranquility meets transformation. Nestled in the heart of Craiova, our haven offers a serene escape from the hustle and bustle of everyday life. Step into our luxurious sanctuary and embark on a journey of self-care and rejuvenation.\r\n\r\nOur team of skilled professionals is dedicated to providing unparalleled service tailored to your unique needs. Whether you're craving a glamorous makeover, a relaxing massage, or a rejuvenating facial, we have a wide range of services to pamper you from head to toe.", "Serene Haven Salon & Spa" });

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalonId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalonId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalonId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalonId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Description", "Name", "SalonId" },
                values: new object[,]
                {
                    { 5, "Relax and unwind with our signature massage, tailored to soothe muscles and promote deep relaxation.", "Serenity Signature Massage", 1 },
                    { 6, "Revive your skin's natural glow with our customized facial, leaving you with a luminous complexion", "Radiance Renewal Facial", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Description 1", "Beauty Salon 1" });

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalonId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalonId",
                value: 1);
        }
    }
}
