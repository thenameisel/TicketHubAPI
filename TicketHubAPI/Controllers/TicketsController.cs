using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ILogger<TicketsController> _logger;
        private readonly IConfiguration _config;

        public TicketsController(ILogger<TicketsController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from MyContactsController - Get()");
        }

        [HttpPost]
        public IActionResult Post(Ticket ticket)
        {
            return Ok("Hello " + ticket.name + " from MyContactsController - Post()");
        }
    }
}
