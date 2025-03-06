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
        [HttpGet]
        public async Task<IActionResult> GetGreetings()
        {
            var greetings = await _greetingService.GetGreetingsAsync();
            return Ok(greetings);
        }

        // New Endpoint: GET: api/greeting/{id}
        // Retrieves a greeting message by its Id.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGreetingById(int id)
        {
            var greeting = await _greetingService.GetGreetingByIdAsync(id);
            if (greeting == null)
            {
                return NotFound(new { Message = $"Greeting with id {id} not found." });
            }
            return Ok(greeting);
        }

        // POST: api/greeting
        [HttpPost]
        public async Task<IActionResult> SaveGreeting([FromBody] GreetingDto dto)
        {
            await _greetingService.SaveGreetingAsync(dto.Message);
            return Ok(new { Message = "Greeting saved successfully." });
        }

        // PUT: api/greeting/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGreeting(int id, [FromBody] GreetingDto dto)
        {
            await _greetingService.UpdateGreetingAsync(id, dto.Message);
            return Ok(new { Message = "Greeting updated successfully." });
        }

        // DELETE: api/greeting/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGreeting(int id)
        {
            await _greetingService.DeleteGreetingAsync(id);
            return Ok(new { Message = "Greeting deleted successfully." });
        }
    }
}
