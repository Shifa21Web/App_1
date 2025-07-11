using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_1.Migrations
{
    /// <inheritdoc />
    public partial class addedlanguagetbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Language_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_LanguageId",
                table: "Book",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_LanguageId",
                table: "Language",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Language_LanguageId",
                table: "Book",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Language_LanguageId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Book_LanguageId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Book");
        }
    }
}
