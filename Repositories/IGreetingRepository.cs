using GreetingApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Repositories
{
    public interface IGreetingRepository
    {
        Task<IEnumerable<Greeting>> GetAllGreetingsAsync();
        Task AddGreetingAsync(Greeting greeting);
        Task UpdateGreetingAsync(int id, string message);
        Task DeleteGreetingAsync(int id);
    }
}
