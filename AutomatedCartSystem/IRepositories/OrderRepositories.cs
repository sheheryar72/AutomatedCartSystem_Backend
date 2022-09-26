using AutomatedCartSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.IRepositories
{
    public interface OrderRepositories
    {
        int Add(Order order);
        int Update(Order order);
        List<Order> GetAll();
        Order GetById(int Id);
        int Delete(int Id);
    }
}
