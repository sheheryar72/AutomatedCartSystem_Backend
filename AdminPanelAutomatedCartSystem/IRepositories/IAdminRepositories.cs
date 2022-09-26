using AdminPanelAutomatedCartSystem.Models;
using System.Collections.Generic;

namespace AdminPanelAutomatedCartSystem.IRepositories
{
    public interface IAdminRepositories
    {
        int Add(Admin admin);
        int Update(Admin admin);
        List<Admin> GetAll();
        Admin GetById(int Id);
        int Delete(int Id);
    }
}
