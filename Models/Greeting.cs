namespace GreetingApp.Models
{
    public class Greeting
    {
        public int Id { get; set; }  // Primary key (auto-incremented)
        public string Message { get; set; } = string.Empty;  // The greeting text
    }
}
