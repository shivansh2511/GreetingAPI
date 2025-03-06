using GreetingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Repositories
{
    public interface IGreetingRepository
    {
        // Returns all greetings from the database.
        Task<IEnumerable<Greeting>> GetAllGreetingsAsync();
        Task<Greeting> GetGreetingByIdAsync(int id);
        Task AddGreetingAsync(Greeting greeting);
        Task UpdateGreetingAsync(int id, string message);
        Task DeleteGreetingAsync(int id);
    }
}
