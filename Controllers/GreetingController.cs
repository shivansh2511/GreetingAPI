using GreetingApp.Models;
using GreetingApp.Services;
using Microsoft.AspNetCore.Mvc;

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
        
        // GET: api/greeting/personalized?firstName=John&lastName=Doe
        [HttpGet("personalized")]
        public IActionResult GetPersonalizedGreeting([FromQuery] string? firstName, [FromQuery] string? lastName)
        {
            var request = new GreetingRequest { FirstName = firstName, LastName = lastName };
            var message = _greetingService.GetPersonalizedGreeting(request);
            return Ok(new { Message = message });
        }
        
        // POST: api/greeting/personalized
        // Expected JSON body: { "FirstName": "John", "LastName": "Doe" }
        [HttpPost("personalized")]
        public IActionResult PostPersonalizedGreeting([FromBody] GreetingRequest request)
        {
            var message = _greetingService.GetPersonalizedGreeting(request);
            return Ok(new { Message = message });
        }
        
        // PUT: api/greeting/personalized
        // Expected JSON body: { "FirstName": "John", "LastName": "Doe" }
        [HttpPut("personalized")]
        public IActionResult PutPersonalizedGreeting([FromBody] GreetingRequest request)
        {
            var message = _greetingService.GetPersonalizedGreeting(request);
            return Ok(new { Message = message });
        }
        
        // DELETE: api/greeting/personalized?firstName=John&lastName=Doe
        [HttpDelete("personalized")]
        public IActionResult DeletePersonalizedGreeting([FromQuery] string? firstName, [FromQuery] string? lastName)
        {
            var request = new GreetingRequest { FirstName = firstName, LastName = lastName };
            var message = _greetingService.GetPersonalizedGreeting(request);
            return Ok(new { Message = message });
        }
    }
}
