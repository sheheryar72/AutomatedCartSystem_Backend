using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Barcode { get; set; }
        public int AdminId { get; set; }
    }
}
