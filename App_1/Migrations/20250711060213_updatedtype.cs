using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App_1.Migrations
{
    /// <inheritdoc />
    public partial class updatedtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Language_Language_LanguageId",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_LanguageId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Language");

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookPrice_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookPrice_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Indian INR", "INR" },
                    { 2, "Dollar", "Dollar" },
                    { 3, "Euro", "Euro" },
                    { 4, "Dinar", "Dinar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookPrice_BookId",
                table: "BookPrice",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrice_CurrencyId",
                table: "BookPrice",
                column: "CurrencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookPrice");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Language",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Language_LanguageId",
                table: "Language",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Language_LanguageId",
                table: "Language",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }
    }
}
