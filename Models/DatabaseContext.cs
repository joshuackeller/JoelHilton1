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

        protected override void OnModelCreating(ModelBuilder movie)
        {
            movie.Entity<AddMovieModel>().HasData(
                new AddMovieModel
                {
                    MovieId = 1,
                    Category = "Musical",
                    Title = "West Side Story",
                    Year = 2021,
                    Director = "Steven Spielberg",
                    Rating = "PG-13",
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
                    Rating = "PG-13",
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
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                }
                );
        }
    }
}
