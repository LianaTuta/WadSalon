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
            migrationBuilder.InsertData("Salons",
            columns: new[] { nameof(SalonModel.Id), nameof(SalonModel.Name), nameof(SalonModel.ImagePath), nameof(SalonModel.Description), nameof(SalonModel.Address) },
            values: new object[,] {
                   { 1, "Beauty Salon 1", "salon1.jpg", "Description 1" , "Address 1" },
                   { 2, "Beauty Salon 2", "salon1.jpg", "Description 2" , "Address 2" },
                   { 3, "Beauty Salon 3", "salon1.jpg", "Description 3" , "Address 3"},
                   { 4, "Beauty Salon 4", "salon1.jpg", "Description 4" , "Address 4" }
            });
            migrationBuilder.InsertData("Products",
            columns: new[] { nameof(ProductModel.Id), nameof(ProductModel.Name), nameof(ProductModel.Price), nameof(ProductModel.SalonId), nameof(ProductModel.Description) },
            values: new object[,] {
                   { 1, "Gel Nails", 12, 1, "Description nails" },
                   { 2, "Hair Treatment",  14, 1, "Descriptions hair" },
                   { 3, "Haircut", 15, 1, "Description hair" },
                   { 4, "Facials",  16, 1, "Desctiption hair"}
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var keyValues = new Object[] { 1, 2, 3, 4 };
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValues: keyValues);
            
            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValues: keyValues);
        }
    }
}
