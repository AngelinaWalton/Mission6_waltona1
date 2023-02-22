using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_waltona1.Models
{
    public class MovieFormContext : DbContext
    {
        // Constructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {
            // leave balnk for now
        }
        
        public DbSet<FormResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Drama" },
                new Category { CategoryId = 5, CategoryName = "Fantasy" },
                new Category { CategoryId = 6, CategoryName = "Horror" },
                new Category { CategoryId = 7, CategoryName = "Musical" },
                new Category { CategoryId = 8, CategoryName = "Mystery" },
                new Category { CategoryId = 9, CategoryName = "Romance" },
                new Category { CategoryId = 10, CategoryName = "Science Fiction" },
                new Category { CategoryId = 11, CategoryName = "Sports" },
                new Category { CategoryId = 12, CategoryName = "Thriller" },
                new Category { CategoryId = 13, CategoryName = "Western" }
            );
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    FormId = 1,
                    CategoryId = 4,
                    title = "Glass Onion",
                    year = 2022,
                    director = "Not Sure",
                    rating = "PG-13",
                    edited = false,
                    lent = "no",
                    notes = "N/A"
                },
                new FormResponse
                {
                    FormId = 2,
                    CategoryId = 1,
                    title = "Red Notice",
                    year = 2022,
                    director = "Not Sure",
                    rating = "PG-13",
                    edited = false,
                    lent = "yes",
                    notes = "N/A"
                },
                new FormResponse
                {
                    FormId = 3,
                    CategoryId = 9,
                    title = "Me Before You",
                    year = 2016,
                    director = "Not Sure",
                    rating = "PG-13",
                    edited = false,
                    lent = "yes",
                    notes = "N/A"
                }
            );
        }
    }
}
