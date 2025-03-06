using GreetingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Services
{
    public interface IGreetingService
    {
        Task<IEnumerable<Greeting>> GetGreetingsAsync();
        Task<Greeting> GetGreetingByIdAsync(int id);
        Task SaveGreetingAsync(string message);
        Task UpdateGreetingAsync(int id, string message);  // Service method for editing
        Task DeleteGreetingAsync(int id);
    }
}
