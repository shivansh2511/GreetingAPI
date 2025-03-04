namespace GreetingApp.Repositories
{
    public class GreetingRepository : IGreetingRepository
    {
        public string GetGreeting()
        {
            return "Hello World";
        }
    }
}
