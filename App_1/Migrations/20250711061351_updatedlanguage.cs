using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App_1.Migrations
{
    /// <inheritdoc />
    public partial class updatedlanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "English", "English" },
                    { 2, "Hindi", "Hindi" },
                    { 3, "Marathi", "Marathi" },
                    { 4, "Punjabi", "Punjabi" },
                    { 5, "Tamil", "Tamil" },
                    { 6, "Urdu", "Urdu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
