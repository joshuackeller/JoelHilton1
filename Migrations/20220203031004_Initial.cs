using Microsoft.EntityFrameworkCore.Migrations;

namespace JoelHilton1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Category = table.Column<string>(nullable: false),
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
                        name: "FK_responses_ratings_RatingMovieRatingId",
                        column: x => x.RatingMovieRatingId,
                        principalTable: "ratings",
                        principalColumn: "MovieRatingId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "MovieRatingId", "Notes", "RatingMovieRatingId", "Title", "Year" },
                values: new object[] { 1, "Musical", "Steven Spielberg", false, null, 2, null, null, "West Side Story", 2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "MovieRatingId", "Notes", "RatingMovieRatingId", "Title", "Year" },
                values: new object[] { 2, "Fiction", "Jason Reitman", false, null, 2, null, null, "Ghostbusters: Afterlife", 2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "MovieRatingId", "Notes", "RatingMovieRatingId", "Title", "Year" },
                values: new object[] { 3, "Fiction", "Jon Watts", false, null, 2, null, null, "Spiderman: No Way Home", 2021 });

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
                name: "ratings");
        }
    }
}
