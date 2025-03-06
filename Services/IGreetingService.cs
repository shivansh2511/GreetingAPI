using GreetingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Services
{
    public interface IGreetingService
    {
        // UC6: List all greeting messages
        Task<IEnumerable<Greeting>> GetGreetingsAsync();
        Task<Greeting> GetGreetingByIdAsync(int id);
        Task SaveGreetingAsync(string message);
        Task UpdateGreetingAsync(int id, string message);
        Task DeleteGreetingAsync(int id);
    }
}
