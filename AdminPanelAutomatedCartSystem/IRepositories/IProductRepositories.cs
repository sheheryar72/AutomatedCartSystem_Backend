using AdminPanelAutomatedCartSystem.Models;
using System.Collections.Generic;

namespace AdminPanelAutomatedCartSystem.IRepositories
{
    public interface IProductRepositories
    {
        int Add(Product product);
        int Update(Product product);
        List<Product> GetAll();
        Product GetById(int Id);
        int Delete(int Id);
    }
}
