using Microsoft.AspNetCore.Mvc;

namespace Hogwarts_Back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Admission : ControllerBase
    {


        private readonly ILogger<Admission> _logger;

        public Admission(ILogger<Admission> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAdmissionRequest")]
        public dynamic Get()
        {
            return "";
        }
    }
}