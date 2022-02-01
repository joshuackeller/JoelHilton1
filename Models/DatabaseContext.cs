using System;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base (options)
        {

        }

        public DbSet<AddMovieModel> responses { get; set; }
    }
}
