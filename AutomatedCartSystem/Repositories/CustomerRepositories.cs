using AutomatedCartSystem.IRepositories;
using AutomatedCartSystem.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AutomatedCartSystem.Repositories
{
    public class CustomerRepositories : ICustomerRepositories
    {
        private readonly IDbConnection conn;
        public CustomerRepositories(IDbConnection _conn)
        {
            conn = _conn;
        }
        public bool Authenticate(string Email, string Password)
        {
            string query = "select * from Customer where Email = @Email and [Password] = @Password";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("Email", Email);
            _parameter.Add("Password", Password);
            Customer result = conn.Query<Customer>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            if(result != null)
            {
                if (Email == result.Email  && Password == result.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public int Add(Customer customer)
        {
            string query = "Insert into Customer Values(@Name, @Email, @Password ,@CNIC, @Address, @City, @ZipCode) SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("Name", customer.Name);
            _parameter.Add("Email", customer.Email);
            _parameter.Add("Password", customer.Password);
            _parameter.Add("CNIC", customer.CNIC);
            _parameter.Add("Address", customer.Address);
            _parameter.Add("City", customer.City);
            _parameter.Add("ZipCode", customer.ZipCode);
            /*_parameter.Add("Active", customer.Active);
            _parameter.Add("CreatedBy", customer.CreatedBy);
            _parameter.Add("CreatedOn", customer.CreatedOn);
            _parameter.Add("ModifiedBy", customer.ModifiedBy);
            _parameter.Add("ModifiedOn", customer.ModifiedOn);*/
            return conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            string query = "Select * From Customer";
            List<Customer> data = conn.Query<Customer>(query, commandType: CommandType.Text).ToList();
            return data;
        }

        public Customer GetById(int Id)
        {
            string query = "Select * from Customer where Id = @Id";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Id", Id);
            Customer data = conn.Query<Customer>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
            return data;
        }
        
        public Customer GetByEmail(string Email)
        {
            try
            {
                string query = "Select * from Customer where Email = @Email";
                var _parameter = new Dictionary<string, object>();
                _parameter.Add("@Email", Email);
                Customer data = conn.Query<Customer>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ResetPassword(ResetPassword model)
        {
            string query = "Update Customer set Password = @NewPassword where Email = @Email  SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];";
            var _parameter = new Dictionary<string, object>();
            _parameter.Add("@Email", model.UserEmail);
            _parameter.Add("@NewPassword", model.NewPassword);
            return conn.Query<int>(query, param: _parameter, commandType: CommandType.Text).FirstOrDefault();
        }

        public int Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string htmlString, string email)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("sheheryarizhar@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = "Reset Password";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("sheheryarizhar@gmail.com", "wkrnlzcqkrzhmuqf");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
        
    }
}
