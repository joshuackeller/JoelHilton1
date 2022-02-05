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
        public DbSet<Category> categories { get; set; }

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

            movie.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Sports",
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Musical",
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Fantasy",
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Fiction",
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Historical",
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Science Fiction",
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Horror",
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Mystery",
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Crime",
                }
                );

            movie.Entity<AddMovieModel>().HasData(
                new AddMovieModel
                {
                    MovieId = 1,
                    CategoryId = 2,
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
                    CategoryId = 4,
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
                    CategoryId = 6,
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
