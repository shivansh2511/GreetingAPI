using GreetingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Repositories
{
    public interface IGreetingRepository
    {
        Task<IEnumerable<Greeting>> GetAllGreetingsAsync();
        Task<Greeting> GetGreetingByIdAsync(int id); // New method for UC5
        Task AddGreetingAsync(Greeting greeting);
        Task UpdateGreetingAsync(int id, string message);
        Task DeleteGreetingAsync(int id);
    }
}
