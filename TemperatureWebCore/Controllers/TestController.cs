using Microsoft.AspNetCore.Mvc;

namespace TemperatureWebCore.Controllers
{
    [Route("/api/[Controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Succsessfull test");
        }
    }
}
