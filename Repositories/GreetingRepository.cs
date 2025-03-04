namespace GreetingApp.Repositories
{
    public class GreetingRepository : IGreetingRepository
    {
        public string GetTestGreeting(string httpMethod)
        {
            // Return a simple message based on the HTTP method
            return $"{httpMethod}: Greeting response from Repository";
        }
    }
}
