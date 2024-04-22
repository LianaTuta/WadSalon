using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salon.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Welcome to Enchanted Elegance Beauty Lounge, where every visit is a magical experience. Step into our luxurious sanctuary and immerse yourself in a world of enchantment, where beauty meets elegance.\r\n\r\nOur talented team of professionals is dedicated to providing you with top-notch service, tailored to your unique needs and desires. Whether you're seeking a glamorous makeover, a relaxing spa treatment, or expertly styled hair, we have everything you need to enhance your natural beauty and leave you feeling radiant.\r\n\r\nAt Enchanted Elegance, we believe in using only the finest quality products, carefully selected to deliver exceptional results. From luxurious skincare to premium hair care, every detail is designed to pamper you from head to toe and make you feel like royalty.", "Enchanted Beauty Lounge" });

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Beauty Salon with Name 3");

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Beauty Salon with Name 4");

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalonId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalonId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalonId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SalonId" },
                values: new object[] { "Description gel nails", 4 });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Description", "Name", "SalonId" },
                values: new object[,]
                {
                    { 7, "Pamper your hands and feet with our Fairy Tale Manicure/Pedicure, complete with luxurious treatments and enchanting nail art.", "Fairy Tale Manicure/Pedicure", 2 },
                    { 8, "Enhance your features with our Natural Makeup Application, perfect for a subtle yet polished look.", "Natural Makeup Application", 2 },
                    { 9, "Nourish your hair with our Nourishing Hair Treatment, restoring health and shine to your locks.", "Nourishing Hair Treatment", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Description 2", "Beauty Salon 2" });

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Beauty Salon 3");

            migrationBuilder.UpdateData(
                table: "Salon",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Beauty Salon 4");

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
                columns: new[] { "Description", "SalonId" },
                values: new object[] { "Description facials", 2 });
        }
    }
}
