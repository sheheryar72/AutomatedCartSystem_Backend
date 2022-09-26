using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Models
{
    public class ResetPassword
    {
        public string UserEmail { get; set; }
        public string NewPassword { get; set; }
    }
}
