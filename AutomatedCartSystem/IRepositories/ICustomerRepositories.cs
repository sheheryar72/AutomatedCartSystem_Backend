using AutomatedCartSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.IRepositories
{
    public interface ICustomerRepositories
    {
        bool Authenticate(string Email, string Password);
        int Add(Customer customer);
        int Update(Customer customer);
        List<Customer> GetAll();
        Customer GetById(int Id);
        Customer GetByEmail(string Email);
        int Delete(int Id);
        int ResetPassword(ResetPassword model);
        void SendEmail(string htmlString, string email);
    }
}
