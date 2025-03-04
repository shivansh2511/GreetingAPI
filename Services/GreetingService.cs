using GreetingApp.Models;
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
        
        public string GetGreeting()
        {
            return _greetingRepository.GetGreeting();
        }
        
        public string GetPersonalizedGreeting(GreetingRequest request)
        {
            // Check if both FirstName and LastName are provided
            if (!string.IsNullOrWhiteSpace(request.FirstName) && !string.IsNullOrWhiteSpace(request.LastName))
            {
                return $"Hello {request.FirstName} {request.LastName}";
            }
            // Check if only FirstName is provided
            else if (!string.IsNullOrWhiteSpace(request.FirstName))
            {
                return $"Hello {request.FirstName}";
            }
            // Check if only LastName is provided
            else if (!string.IsNullOrWhiteSpace(request.LastName))
            {
                return $"Hello {request.LastName}";
            }
            // Otherwise, return the default greeting
            else
            {
                return _greetingRepository.GetGreeting();
            }
        }
    }
}
