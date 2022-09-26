using Microsoft.AspNetCore.Mvc;

namespace AutomatedCartSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost("Practice1")]
        public IActionResult Practice1(int id)
        {
            var data = id;
            return Ok("This is practice1 controller " + data);
        }
        [HttpPost("Practice2")]
        public IActionResult Practice2([FromBody] int id)
        {
            var data = id;
            return Ok("This is practice2 controller " + data);
        }
        [HttpPost("Practice3")]
        public IActionResult Practice3([FromQuery] int id)
        {
            var data = id;
            return Ok("This is practice3 controller " + data);
        }
        [HttpPost("Practice4")]
        public IActionResult Practice4([FromForm] int id)
        {
            var data = id;
            return Ok("This is practice4 controller " + data);
        }
        [HttpPost("Practice5")]
        public IActionResult Practice5([FromHeader] int id)
        {
            var data = id;
            return Ok("This is practice5 controller " + data);
        }
    }
}
