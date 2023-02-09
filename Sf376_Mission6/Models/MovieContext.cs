using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sf376_Mission6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seed the table with 3 of my favorite movies

            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    Title = "The Agengers",
                    Category = "Action/Adventure",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "This is a classic"
                },
                new ApplicationResponse
                {
                    Title = "Batman Begins",
                    Category = "Action/Adventure",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "This is my favorite!"
                },
                new ApplicationResponse
                {
                    Title = "Lord of the Rings: The Return of the King",
                    Category = "Action/Adventure",
                    Year = 2003,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "I had no idea this was from 2003 haha"
                }
            );
        }
    }
        
}
