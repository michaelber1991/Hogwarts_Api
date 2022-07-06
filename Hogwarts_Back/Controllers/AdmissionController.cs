using Hogwarts.BL.Services;
using Hogwarts.BL.Services.Interfaces;
using Hogwarts.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Hogwarts_Back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdmissionController : ControllerBase
    {
        private readonly ILogger<AdmissionController> _logger;
        private readonly IAdmissionService _admissionService;

        public AdmissionController(ILogger<AdmissionController> logger, IAdmissionService admissionService)
        {
            _logger = logger;
            _admissionService = admissionService;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult AddAdmissionRequest(AdmissionRequestDto admissionRequestDto)
        {
            return Ok(_admissionService.AddAdmissionRequest(admissionRequestDto));
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAllAdmissionRequest()
        {
            return Ok(_admissionService.GetAllAdmissionRequest());
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult UpdateAdmissionRequest(AdmissionRequestDto admissionRequestDto)
        {
            return Ok(_admissionService.UpdateAdmissionRequest(admissionRequestDto));
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteAdmissionRequest(string identification)
        {
            return Ok(_admissionService.DeleteAdmissionRequest(identification));
        }


    }
}