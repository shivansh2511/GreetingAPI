using GreetingApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Repositories
{
    public class GreetingRepository : IGreetingRepository
    {
        private readonly AppDbContext _context;

        public GreetingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Greeting>> GetAllGreetingsAsync()
        {
            return await _context.Greetings.ToListAsync();
        }

        public async Task<Greeting> GetGreetingByIdAsync(int id)
        {
            return await _context.Greetings.FindAsync(id);
        }

        public async Task AddGreetingAsync(Greeting greeting)
        {
            await _context.Greetings.AddAsync(greeting);
            await _context.SaveChangesAsync();
        }

        // Update (edit) a greeting message
        public async Task UpdateGreetingAsync(int id, string message)
        {
            // Find the greeting by its primary key
            var greeting = await _context.Greetings.FindAsync(id);
            if (greeting != null)
            {
                greeting.Message = message;  // Update the message
                await _context.SaveChangesAsync();  // Save changes to the database
            }
        }

        public async Task DeleteGreetingAsync(int id)
        {
            var greeting = await _context.Greetings.FindAsync(id);
            if (greeting != null)
            {
                _context.Greetings.Remove(greeting);
                await _context.SaveChangesAsync();
            }
        }
    }
}
