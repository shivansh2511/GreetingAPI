using GreetingApp.Models;
using GreetingApp.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreetingApp.Services
{
    public class GreetingService : IGreetingService
    {
        private readonly IGreetingRepository _greetingRepository;

        public GreetingService(IGreetingRepository greetingRepository)
        {
            _greetingRepository = greetingRepository;
        }

        public async Task<IEnumerable<Greeting>> GetGreetingsAsync()
        {
            return await _greetingRepository.GetAllGreetingsAsync();
        }

        public async Task<Greeting> GetGreetingByIdAsync(int id)
        {
            return await _greetingRepository.GetGreetingByIdAsync(id);
        }

        public async Task SaveGreetingAsync(string message)
        {
            var greeting = new Greeting { Message = message };
            await _greetingRepository.AddGreetingAsync(greeting);
        }

        public async Task UpdateGreetingAsync(int id, string message)
        {
            await _greetingRepository.UpdateGreetingAsync(id, message);
        }

        public async Task DeleteGreetingAsync(int id)
        {
            await _greetingRepository.DeleteGreetingAsync(id);
        }
    }
}
