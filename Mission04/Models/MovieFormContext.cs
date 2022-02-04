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
        public DbSet<Category> Categories { get; set; }

        // Seeding Data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId=1, CategoryName="Action/Adventure"},
                    new Category { CategoryId=2, CategoryName="Comedy"},
                    new Category { CategoryId=3, CategoryName="Drama"},
                    new Category { CategoryId=4, CategoryName="Family"},
                    new Category { CategoryId=5, CategoryName="Horror/Suspense"},
                    new Category { CategoryId=6, CategoryName="Miscellaneous"},
                    new Category { CategoryId=7, CategoryName="Television"},
                    new Category { CategoryId=8, CategoryName="VHS"}
                );

            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    MovieId = 1,
                    CategoryId = 3,
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
                    CategoryId = 3,
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
                    CategoryId = 3,
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
