using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission04.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 0, "Drama", "J.A. Bayona", false, "", "", "PG-13", "The Impossible", (ushort)2012 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 0, "Historical Drama", "Lee Daniels", false, "", "", "PG-13", "The Butler", (ushort)2013 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 0, "Drama", "Tate Taylor", false, "", "", "PG-13", "The Help", (ushort)2011 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
