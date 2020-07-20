using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Demo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IActionResult GetList()
        {
            _logger.LogWarning("test log warning");
            _logger.LogError("test log error");
            _logger.LogCritical("test log critical");

            return Ok();
        }
    }
}
