using System;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<AddMovieModel> responses { get; set; }
        public DbSet<Rating> ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder movie)
        {
            movie.Entity<Rating>().HasData(
                new Rating
                {
                    MovieRatingId = 1,
                    MovieRating = "G",
                },
                new Rating
                {
                MovieRatingId = 2,
                    MovieRating = "PG",
                },
                new Rating
                {
                    MovieRatingId = 3,
                    MovieRating = "PG-13",
                },
                new Rating
                {
                    MovieRatingId = 4,
                    MovieRating = "R",
                }

                );

            movie.Entity<AddMovieModel>().HasData(
                new AddMovieModel
                {
                    MovieId = 1,
                    Category = "Musical",
                    Title = "West Side Story",
                    Year = 2021,
                    Director = "Steven Spielberg",
                    MovieRatingId = 2,
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },
                new AddMovieModel
                {
                    MovieId = 2,
                    Category = "Fiction",
                    Title = "Ghostbusters: Afterlife",
                    Year = 2021,
                    Director = "Jason Reitman",
                    MovieRatingId = 2,
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },
                new AddMovieModel
                {
                    MovieId = 3,
                    Category = "Fiction",
                    Title = "Spiderman: No Way Home",
                    Year = 2021,
                    Director = "Jon Watts",
                    MovieRatingId = 2,
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                }
                );
        }

        internal void Delete(AddMovieModel movie)
        {
            throw new NotImplementedException();
        }
    }
}
