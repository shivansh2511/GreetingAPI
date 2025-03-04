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
        
        // GET: api/greeting
        [HttpGet]
        public IActionResult GetGreeting()
        {
            var message = _greetingService.GetGreeting();
            return Ok(new { Message = message });
        }
        
        // POST: api/greeting
        [HttpPost]
        public IActionResult PostGreeting()
        {
            var message = _greetingService.GetGreeting();
            return Ok(new { Message = message });
        }
        
        // PUT: api/greeting
        [HttpPut]
        public IActionResult PutGreeting()
        {
            var message = _greetingService.GetGreeting();
            return Ok(new { Message = message });
        }
        
        // DELETE: api/greeting
        [HttpDelete]
        public IActionResult DeleteGreeting()
        {
            var message = _greetingService.GetGreeting();
            return Ok(new { Message = message });
        }
    }
}
