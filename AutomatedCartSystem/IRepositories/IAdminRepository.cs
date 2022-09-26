using AutomatedCartSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.IRepositories
{
    public interface IAdminRepository
    {
        int Add(Admin admin);
        int Update(Admin admin);
        List<Admin> GetAll();
        Admin GetById(int Id);
        int Delete(int Id);
    }
}
