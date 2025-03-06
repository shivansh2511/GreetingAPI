using GreetingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Services
{
    public interface IGreetingService
    {
        Task<IEnumerable<Greeting>> GetGreetingsAsync();
        Task<Greeting> GetGreetingByIdAsync(int id); // New method for UC5
        Task SaveGreetingAsync(string message);
        Task UpdateGreetingAsync(int id, string message);
        Task DeleteGreetingAsync(int id);
    }
}
