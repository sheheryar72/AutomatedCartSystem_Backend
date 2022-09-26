using AutomatedCartSystem.IRepositories;
using AutomatedCartSystem.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("CorsApi")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepositories customerRepositories;
        public CustomerController(ICustomerRepositories _customerRepositories)
        {
            customerRepositories = _customerRepositories;
        }
        [HttpPost("Authenticate")]
        public IActionResult Authenticate(string Email, string Password)
        {
            bool result = customerRepositories.Authenticate(Email, Password);
            return Ok(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            if (ModelState.IsValid)
            {
                int result = customerRepositories.Add(customer);
                if (result > 0)
                    return Ok(result);
                return Ok(0);
            }
            return Ok("Customer Not Inserted");
        }
        [HttpGet("Forgot")]
        public IActionResult Forgot([FromQuery] Forgot model)
        {
            if (ModelState.IsValid)
            {
                if (customerRepositories.GetByEmail(model.Email) != null)
                {
                    //string massage = $"<a href=\"https://{ HttpContext.Request.Host}/api/reset?UserEmail={model.Email}\"";
                    string resetpsw = $"<a href=\"https://{ HttpContext.Request.Host}/api/ResetPasswordForm?UserEmail={model.Email}\"";
                    customerRepositories.SendEmail(resetpsw, model.Email);
                    return Ok(resetpsw);
                }
                return Ok("Email does not exist");
            }
            else
            {
                return Ok();
            }
        }

        [HttpGet("ResetPasswordForm")]
        public IActionResult ResetPasswordForm(string UserEmail)
        {
            ViewBag.UserEmail = UserEmail;
            return View();
        }

        [HttpPost("ResetPassword")]
        public IActionResult ResetPassword(ResetPassword model)
        {
            if (model.NewPassword != null)
            {
                customerRepositories.ResetPassword(model);
                return Ok();
            }
            return Ok();
        }

        [HttpPost("GetById")]
        public IActionResult GetById(int Id)
        {
            if(Id != 0)
            {
                Customer customer = customerRepositories.GetById(Id);
                return Ok(customer);
            }
            return Ok("Id cannot be null");
        }
        [HttpPost("GetByEmail")]
        public IActionResult GetByEmail(string Email)
        {
            if(Email != null)
            {
                Customer customer = customerRepositories.GetByEmail(Email);
                return Ok(customer);
            }
            return Ok("please Enter Email Addrerss");
        }
    }
}
