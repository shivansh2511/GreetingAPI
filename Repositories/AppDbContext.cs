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

        // This DbSet maps to the "Greetings" table in the MySQL database.
        public DbSet<Greeting> Greetings { get; set; }
    }
}
