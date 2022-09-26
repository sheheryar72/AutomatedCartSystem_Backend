using AdminPanelAutomatedCartSystem.IRepositories;
using AdminPanelAutomatedCartSystem.Models;
using System.Collections.Generic;
using System.Data;

namespace AdminPanelAutomatedCartSystem.Repositories
{
    public class AdminRepositories : IAdminRepositories
    {
        private readonly IDbConnection conn;
        public AdminRepositories(IDbConnection _conn)
        {
            conn = _conn;
        }
        public int Add(Admin admin)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Admin> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Admin GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public int Update(Admin admin)
        {
            throw new System.NotImplementedException();
        }
    }
}
