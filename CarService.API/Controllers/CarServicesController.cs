using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarServicesController : ControllerBase
    {
        [HttpGet(Name = "give-me-car")]
        public IActionResult GiveMeMyCar()
        {
            return Ok(new
            {
                Id = 23,
                Brand = "BMW",
                Price = 400_000_000,
                Year = 2024
            });
        }
    }
}
