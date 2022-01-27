using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<FormResponse> responses { get; set; }

        // Seeded Database with 3 movies
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    MovieId = 1,
                    Category = "Drama",
                    Title = "The Impossible",
                    Year = 2012,
                    Director = "J.A. Bayona",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes= ""
                },
                new FormResponse
                {
                    MovieId = 2,
                    Category = "Historical Drama",
                    Title = "The Butler",
                    Year = 2013,
                    Director = "Lee Daniels",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new FormResponse
                {
                    MovieId = 3,
                    Category = "Drama",
                    Title = "The Help",
                    Year = 2011,
                    Director = "Tate Taylor",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
