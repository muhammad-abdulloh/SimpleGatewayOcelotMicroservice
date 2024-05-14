using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet(Name = "give-me")]
        public IActionResult GiveMeMyBook()
        {
            return Ok(new
            {
                Id = 1,
                Name = "Abdulla Avloniy",
                Price = 200.000
            });
        }
    }
}
