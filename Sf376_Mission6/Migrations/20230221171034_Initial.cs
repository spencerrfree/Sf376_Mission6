using Microsoft.EntityFrameworkCore.Migrations;

namespace Sf376_Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catergories",
                columns: table => new
                {
                    CatergoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatergoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catergories", x => x.CatergoryId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.Title);
                    table.ForeignKey(
                        name: "FK_responses_Catergories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catergories",
                        principalColumn: "CatergoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CatergoryId", "CatergoryName" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "The Agengers", 1, "Joss Whedon", false, "", "This is a classic", "PG-13", 2012 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Batman Begins", 1, "Christopher Nolan", false, "", "This is my favorite!", "PG-13", 2005 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Lord of the Rings: The Return of the King", 1, "Peter Jackson", false, "", "I had no idea this was from 2003 haha", "PG-13", 2003 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryId",
                table: "responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Catergories");
        }
    }
}
