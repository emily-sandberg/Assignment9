using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment9.Models
{
    public class MovieDbContext : DbContext //inherits from ef core dbcontext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base (options) //constructor
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
