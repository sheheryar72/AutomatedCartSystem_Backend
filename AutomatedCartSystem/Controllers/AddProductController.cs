using AutomatedCartSystem.IRepositories;
using AutomatedCartSystem.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AutomatedCartSystem.Controllers
{
    /*[EnableCors("CorsApi")]*/
    public class AddProductController : Controller
    {
        private readonly IProductRepositories productRepositories;
        public AddProductController(IProductRepositories _productRepositories)
        {
            productRepositories = _productRepositories;
        }
        [HttpGet("api/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/InsertProduct")]
        public IActionResult InsertProduct([FromForm] Product product)
        {
            int result = productRepositories.Add(product);
            if (result > 0)
                return Ok("data successfully added");
            return Ok("data successfully added");
        }

    }
}
