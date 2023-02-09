using Microsoft.EntityFrameworkCore.Migrations;

namespace Sf376_Mission6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "The Agengers", "Action/Adventure", "Joss Whedon", false, "", "This is a classic", "PG-13", 2012 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Batman Begins", "Action/Adventure", "Christopher Nolan", false, "", "This is my favorite!", "PG-13", 2005 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Lord of the Rings: The Return of the King", "Action/Adventure", "Peter Jackson", false, "", "I had no idea this was from 2003 haha", "PG-13", 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
