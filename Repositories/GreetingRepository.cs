namespace GreetingApp.Repositories
{
    public class GreetingRepository : IGreetingRepository
    {
        public string GetGreeting()
        {
            // Return a simple greeting message for UC2
            return "Hello World";
        }
    }
}
