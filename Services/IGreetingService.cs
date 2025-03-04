using GreetingApp.Models;

namespace GreetingApp.Services
{
    public interface IGreetingService
    {
        string GetGreeting();
        string GetPersonalizedGreeting(GreetingRequest request);
    }
}
