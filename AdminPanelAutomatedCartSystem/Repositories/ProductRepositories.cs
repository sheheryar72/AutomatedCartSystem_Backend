using AdminPanelAutomatedCartSystem.IRepositories;
using AdminPanelAutomatedCartSystem.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AdminPanelAutomatedCartSystem.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly IDbConnection conn;
        public ProductRepositories(IDbConnection _conn)
        {
            conn = _conn;
        }
        public int Add(Product product)
        {
            string query = "Insert into Product values (@Name, @Category, @ShortDiscription, @LongDiscription, @Price, @Quantity, @Active, @CreatedBy, @CreatedOn, @ModifiedBy, @ModifiedOn, @AdminId) SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("Name", product.Name);
            _parameter.Add("Category", product.Category);
            _parameter.Add("v", product.ShortDiscription);
            _parameter.Add("LongDiscription", product.LongDiscription);
            _parameter.Add("Price", product.Price);
            _parameter.Add("Quantity", product.Quantity);
            return conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int Id)
        {
            try
            {
                string query = "Select * from Product where Id = @Id";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("Id", Id);
                Product data = conn.Query<Product>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
