using GreetingApp.Repositories;

namespace GreetingApp.Services
{
    public class GreetingService : IGreetingService
    {
        private readonly IGreetingRepository _greetingRepository;

        public GreetingService(IGreetingRepository greetingRepository)
        {
            _greetingRepository = greetingRepository;
        }

        public string GetTestGreeting(string httpMethod)
        {
            return _greetingRepository.GetTestGreeting(httpMethod);
        }
    }
}
