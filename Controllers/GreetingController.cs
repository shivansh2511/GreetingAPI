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
        
        // GET: api/greeting/test
        [HttpGet("test")]
        public IActionResult GetTest()
        {
            var message = _greetingService.GetTestGreeting("GET");
            return Ok(new { Message = message });
        }
        
        // POST: api/greeting/test
        [HttpPost("test")]
        public IActionResult PostTest()
        {
            var message = _greetingService.GetTestGreeting("POST");
            return Ok(new { Message = message });
        }
        
        // PUT: api/greeting/test
        [HttpPut("test")]
        public IActionResult PutTest()
        {
            var message = _greetingService.GetTestGreeting("PUT");
            return Ok(new { Message = message });
        }
        
        // DELETE: api/greeting/test
        [HttpDelete("test")]
        public IActionResult DeleteTest()
        {
            var message = _greetingService.GetTestGreeting("DELETE");
            return Ok(new { Message = message });
        }
    }
}
