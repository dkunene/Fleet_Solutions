using Microsoft.AspNetCore.Mvc;
using Fleet.Data;
using Fleet.Models;

namespace Fleet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly FleetDbContext _context;

        public DriverController(FleetDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDrivers()
        {
            return Ok(_context.Drivers.ToList());
        }
    }
}
