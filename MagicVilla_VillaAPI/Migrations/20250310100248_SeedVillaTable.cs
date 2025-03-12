using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem whateevr this that", "", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pool, Garden, Spa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem whatever this that.", "https://example.com/royal_villa.jpg", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Sauna, Fireplace, Hiking Trails", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A peaceful retreat in the mountains.", "https://example.com/mountain_retreat.jpg", "Mountain Retreat", 4, 250.0, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Beach Access, Hot Tub", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoy breathtaking ocean views.", "https://example.com/seaside_escape.jpg", "Seaside Escape", 6, 300.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Gym, Rooftop Terrace, Bar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A luxurious villa in the heart of the city.", "https://example.com/city_oasis.jpg", "City Oasis", 3, 180.0, 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Pool, Desert Safari, Star Gazing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An exotic villa amidst the desert.", "https://example.com/desert_mirage.jpg", "Desert Mirage", 4, 220.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Forest Trails, Yoga Studio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A serene escape surrounded by nature.", "https://example.com/forest_haven.jpg", "Forest Haven", 7, 275.0, 650, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
