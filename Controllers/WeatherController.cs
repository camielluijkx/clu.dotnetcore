using Microsoft.AspNetCore.Mvc;

namespace clu.dotnetcore.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        [HttpGet("[action]/{city}")]
        public IActionResult City(string city)
        {
            return Ok(new { Temp = "27", Summary = "Sunny", City = city });
        }
    }
}
