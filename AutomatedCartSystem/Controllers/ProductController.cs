using AutomatedCartSystem.IRepositories;
using AutomatedCartSystem.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("CorsApi")]
    public class ProductController : Controller
    {
        private readonly IProductRepositories productRepositories;
        public ProductController(IProductRepositories _productRepositories)
        {
            productRepositories = _productRepositories;
        }
        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                int result = productRepositories.Add(product);
                if (result > 0)
                    return Ok(result);
                return Ok(0);
            }
            return Ok("Product Not Inserted");
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int Id)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            if (Id != 0)
            {
                Product product = productRepositories.GetById(Id);
                return Ok(product);
            }
            stopWatch.Stop();
            ViewBag.StopWtch = stopWatch.Elapsed;
            return Ok("Id cannot be null");
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var product = productRepositories.GetAll();
            stopWatch.Stop();
            ViewBag.TotalRecord = product.Count;
            ViewBag.TotalTime = stopWatch.Elapsed;
            return Ok( new { ViewBag.TotalRecord, ViewBag.TotalTime, product });
        }
        [HttpGet("GetByBarcode")]
        public IActionResult GetByBarcode([FromQuery] int barcode)
        {
            if (barcode != 0)
            {
                Product product = productRepositories.GetByBarcode(barcode);
                return Ok(product);
            }
            return Ok("Id cannot be null");
        }
    }   
}
