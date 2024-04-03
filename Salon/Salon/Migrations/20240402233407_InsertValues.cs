using Microsoft.EntityFrameworkCore.Migrations;
using Salon.Models;

#nullable disable

namespace Salon.Migrations
{
    /// <inheritdoc />
    public partial class InsertValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Salon",
            columns: new[] { nameof(Models.Salon.Id), nameof(Models.Salon.Name), nameof(Models.Salon.ImagePath), nameof(Models.Salon.Description), nameof(Models.Salon.Address) },
            values: new object[,] {
                   { 1, "Beauty Salon 1", "salon1.jpg", "Description 1" , "Address 1" },
                   { 2, "Beauty Salon 2", "salon1.jpg", "Description 2" , "Address 2" },
                   { 3, "Beauty Salon 3", "salon1.jpg", "Description 3" , "Address 3"},
                   { 4, "Beauty Salon 4", "salon1.jpg", "Description 4" , "Address 4" }
            });
            migrationBuilder.InsertData("Service",
            columns: new[] { nameof(SalonService.Id), nameof(SalonService.Name), nameof(SalonService.SalonId), nameof(SalonService.Description), nameof(SalonService.AppoinmentDate) },
            values: new object[,] {
                   { 1, "Gel Nails", 1,"Description nails" , DateTime.UtcNow},
                   { 2, "Hair Treatment",1, "Descriptions hair" , DateTime.UtcNow},
                   { 3, "Haircut", 1, "Description hair" , DateTime.UtcNow},
                   { 4, "Facials",   1, "Desctiption hair", DateTime.UtcNow}
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var keyValues = new Object[] { 1, 2, 3, 4 };
            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValues: keyValues);

            migrationBuilder.DeleteData(
                table: "Salon",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValues: keyValues);
        }
    }
}
