using Azure.Storage.Queues;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

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

        //[HttpGet]
        //public IActionResult Get()
        //{
           
        //    return Ok("Hello from MyContactsController - Get()");
        //}

        [HttpPost]
        public async Task<IActionResult> Post(Ticket ticket)
        {

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(ModelState);
            }
            else { 

                string queueName = "tickethub";

                string? connectionString = _config["AzureStorageConnectionString"];

                if (string.IsNullOrEmpty(connectionString))
                {
                    return BadRequest("An error was encountered");
                }

                QueueClient queueClient = new QueueClient(connectionString, queueName);

                // serialize an object to json
                string message = JsonSerializer.Serialize(ticket);

                // send string message to queue
                await queueClient.SendMessageAsync(message);

                return Ok("Hello " + ticket.name + " from MyContactsController - Post()");
            }
        }
    }
}
