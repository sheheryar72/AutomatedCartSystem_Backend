using AutomatedCartSystem.IRepositories;
using AutomatedCartSystem.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Repositories
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
            string query = "Insert into Product values (@Name, @Category, @Discription, @Price, @Quantity, @Barcode ,@AdminId) SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("Name", product.Name);
            _parameter.Add("Category", product.Category);
            _parameter.Add("Discription", product.Discription);
            _parameter.Add("Price", product.Price);
            _parameter.Add("Quantity", product.Quantity);
            _parameter.Add("Barcode", product.Barcode);
            _parameter.Add("AdminId", 1);
            return conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            try
            {
                string query = "Select * from Product";
                var data = conn.Query<Product>(query, commandType: CommandType.Text).ToList();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Product GetById(int Id)
        {
            try
            {
                string query = "Select * from Product where Id = @Id";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("@Id", Id);
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
        public Product GetByBarcode(int barcode)
        {
            try
            {
                string query = "Select * from Product where Barcode = @Barcode";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("Barcode", barcode);
                Product data = conn.Query<Product>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
