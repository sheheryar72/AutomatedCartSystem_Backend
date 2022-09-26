using AutomatedCartSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.IRepositories
{
    public interface IProductRepositories
    {
        int Add(Product product);
        int Update(Product product);
        List<Product> GetAll();
        Product GetById(int Id);
        int Delete(int Id);
        Product GetByBarcode(int barcode);
    }
}
