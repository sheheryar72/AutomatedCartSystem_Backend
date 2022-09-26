using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Models
{
    public class Forgot
    {
        [Required, EmailAddress, Display(Name = "Registered Email Address")]
        public string Email { get; set; }
    }
}
