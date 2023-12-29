using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceDescriptionsController : ControllerBase
    {
        IMaintenanceDescriptionService _maintenanceDescriptionService;

        public MaintenanceDescriptionsController(IMaintenanceDescriptionService maintenanceDescriptionService)
        {
            _maintenanceDescriptionService = maintenanceDescriptionService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _maintenanceDescriptionService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _maintenanceDescriptionService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(MaintenanceDescription maintenanceDescription)
        {
            var result = _maintenanceDescriptionService.Add(maintenanceDescription);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MaintenanceDescription maintenanceDescription)
        {
            var result = _maintenanceDescriptionService.Delete(maintenanceDescription);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(MaintenanceDescription maintenanceDescription)
        {
            var result = _maintenanceDescriptionService.Update(maintenanceDescription);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
