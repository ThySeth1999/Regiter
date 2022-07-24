using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class MovieContext:IdentityDbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options):base(options)
        {
                                                
        }

        public DbSet<Movie>Movies { get; set; }
    }
}
