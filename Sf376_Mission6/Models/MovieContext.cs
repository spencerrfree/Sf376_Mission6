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
        public DbSet<Category> Catergories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seed the table with 3 of my favorite movies

            mb.Entity<Category>().HasData(
                new Category
                {
                    CatergoryId = 1,
                    CatergoryName = "Action/Adventure"
                });


            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    Title = "The Agengers",
                    CategoryId = 1,
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
                    CategoryId = 1,
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
                    CategoryId = 1,
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
