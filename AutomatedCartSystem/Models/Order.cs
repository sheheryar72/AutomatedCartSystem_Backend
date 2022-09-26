using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Models
{
    public class Order : ACSCommonClass
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int OrderQuantity { get; set; }
    }
    public class OrderDetails : ACSCommonClass
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
