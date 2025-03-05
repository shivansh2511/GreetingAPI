using GreetingApp.Models;
using GreetingApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GreetingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        // GET: api/greeting
        // Retrieves all saved greetings.
        [HttpGet]
        public async Task<IActionResult> GetGreetings()
        {
            var greetings = await _greetingService.GetGreetingsAsync();
            return Ok(greetings);
        }

        // POST: api/greeting
        // Saves a new greeting.
        // Expected JSON body: { "message": "Hello from Postman!" }
        [HttpPost]
        public async Task<IActionResult> SaveGreeting([FromBody] GreetingDto dto)
        {
            await _greetingService.SaveGreetingAsync(dto.Message);
            return Ok(new { Message = "Greeting saved successfully." });
        }

        // PUT: api/greeting/{id}
        // Updates an existing greeting.
        // Expected JSON body: { "message": "Updated greeting from Postman!" }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGreeting(int id, [FromBody] GreetingDto dto)
        {
            await _greetingService.UpdateGreetingAsync(id, dto.Message);
            return Ok(new { Message = "Greeting updated successfully." });
        }

        // DELETE: api/greeting/{id}
        // Deletes the greeting with the specified ID.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGreeting(int id)
        {
            await _greetingService.DeleteGreetingAsync(id);
            return Ok(new { Message = "Greeting deleted successfully." });
        }
    }
}
