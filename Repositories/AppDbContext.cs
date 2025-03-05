using Microsoft.EntityFrameworkCore;
using GreetingApp.Models;

namespace GreetingApp.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Greeting> Greetings { get; set; } // Represents the Greetings table.
    }
}
