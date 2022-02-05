using Microsoft.EntityFrameworkCore.Migrations;

namespace JoelHilton1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    MovieRatingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieRating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.MovieRatingId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    MovieRatingId = table.Column<int>(nullable: false),
                    RatingMovieRatingId = table.Column<int>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_responses_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_responses_ratings_RatingMovieRatingId",
                        column: x => x.RatingMovieRatingId,
                        principalTable: "ratings",
                        principalColumn: "MovieRatingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Sports" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Musical" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Fantasy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Fiction" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Historical" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Horror" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Mystery" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 9, "Crime" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "MovieRatingId", "MovieRating" },
                values: new object[] { 1, "G" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "MovieRatingId", "MovieRating" },
                values: new object[] { 2, "PG" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "MovieRatingId", "MovieRating" },
                values: new object[] { 3, "PG-13" });

            migrationBuilder.InsertData(
                table: "ratings",
                columns: new[] { "MovieRatingId", "MovieRating" },
                values: new object[] { 4, "R" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "MovieRatingId", "Notes", "RatingMovieRatingId", "Title", "Year" },
                values: new object[] { 1, 2, "Steven Spielberg", false, null, 2, null, null, "West Side Story", 2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "MovieRatingId", "Notes", "RatingMovieRatingId", "Title", "Year" },
                values: new object[] { 2, 4, "Jason Reitman", false, null, 2, null, null, "Ghostbusters: Afterlife", 2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "MovieRatingId", "Notes", "RatingMovieRatingId", "Title", "Year" },
                values: new object[] { 3, 6, "Jon Watts", false, null, 2, null, null, "Spiderman: No Way Home", 2021 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryId",
                table: "responses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_responses_RatingMovieRatingId",
                table: "responses",
                column: "RatingMovieRatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "ratings");
        }
    }
}
