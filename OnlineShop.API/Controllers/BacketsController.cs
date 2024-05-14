using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BacketsController : ControllerBase
    {

        [HttpPost(Name = "set-backet")]
        public IActionResult CreateBacket(Backet backet)
        {
            return Ok(backet);  
        }
    }

    public class Backet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
