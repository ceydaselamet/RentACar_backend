using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenancesController : ControllerBase
    {
        IMaintenanceService _maintenanceService;
        public MaintenancesController(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _maintenanceService.GetAll();
            if(result.Success) 
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id) 
        { 
            var result = _maintenanceService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Maintenance maintenance)
        {
            var result = _maintenanceService.Add(maintenance);
            if(result.Success) 
            {
            return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Maintenance maintenance)
        {
            var result = _maintenanceService.Delete(maintenance);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Maintenance maintenance)
        {
            var result = _maintenanceService.Update(maintenance);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
