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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    FormId = 1,
                    category = "Comedy",
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
                    category = "Adventure",
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
                    category = "Drama",
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
