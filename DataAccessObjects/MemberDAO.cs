using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessObjects
{
    public class MemberDAO
    {
        private OrderDAO orderDAO = new OrderDAO();
        private static MemberDAO instance = null;
        private static object lockOject = new object();
        public MemberDAO() { }
        public static MemberDAO Instance
        {
            get {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
                return instance; }
        }
        public bool IsCustomer(string CustomerEmail, string password)
        {
            using var db = new FStoreDBContext();
            var customer = db.Customers.SingleOrDefault(m => m.Email.Equals(CustomerEmail) && m.Password.Equals(password));
            return (customer != null);
        }
        public bool IsCustomerHaveOrder(int customerId) 
        { 
            var orders = orderDAO.GetOrdersByCustomerID(customerId);
            return (orders != null);
        }
        public List<Customer> GetCustomers()
        {
            using var db = new FStoreDBContext();
            return db.Customers.ToList();
        }
        public Customer GetCustomerById(int? CustomerID)
        {
            using var db = new FStoreDBContext();
            var customer = db.Customers.SingleOrDefault(m => m.CustomerID.Equals(CustomerID));
            return customer;
        }
        public Customer GetCustomerByEmailAndPassword(string Email, string Password)
        {
            using var db = new FStoreDBContext();
            var customer = db.Customers.SingleOrDefault(m => m.Email.Equals(Email) && m.Password.Equals(Password));
            return customer;
        }
        public int AutoGenerateCustomerId()
        {
            using var db = new FStoreDBContext();
            return db.Customers.Max(f => f.CustomerID) + 1;
        }
        public bool SaveCustomer(Customer customer)
        {
            using var db = new FStoreDBContext();
            var customer1 = db.Customers.SingleOrDefault(m => m.CustomerID.Equals(customer.CustomerID));
            if (customer1 != null)
            {
                db.Customers.Remove(customer1);
                db.Customers.Add(customer);
                var effectedRows = db.SaveChanges();
                return (effectedRows > 0);
            }else
            {
                return false;
            }
            
        }
        public bool DeleteCustomerById(int customerId)
        {
            using var db = new FStoreDBContext();
            var DeletingCustomer = db.Customers.SingleOrDefault(m => m.CustomerID.Equals(customerId));
            if (DeletingCustomer != null)
            {
                if (!IsCustomerHaveOrder(customerId))
                {
                    db.Remove(DeletingCustomer);
                    var check = db.SaveChanges();
                    return (check > 0);
                }
            }
            return false;
        }
        public bool AddCustomer(Customer customer)
        {
            using var db = new FStoreDBContext();
            var customer1 = db.Customers.SingleOrDefault(m => m.CustomerID.Equals(customer.CustomerID));
            if (customer1 == null)
            {
                db.Customers.Add(customer);
                var check = db.SaveChanges();
                return (check > 0);
            }
            else
            {
                return false;
            }
        }
        public bool IsAdmin(string Email, string Password)
        {  
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", true, true).Build();
            var AdminEmail = configuration["Admin:Email"];
            var AdminPassord = configuration["Admin:Password"];
            return (Email.Equals(AdminEmail) && Password.Equals(AdminPassord));
        }
        public Admin GetAdmin()
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", true, true).Build();
            var AdminEmail = configuration["Admin:Email"];
            var AdminPassord = configuration["Admin:Password"];
            var Admin = new Admin() {
                Email = AdminEmail,
                Password = AdminPassord
            };
            return Admin;
        }
        public bool CheckLogin(string Email, string Password)
        {
            using var db = new FStoreDBContext();
            return (IsCustomer(Email, Password) || (IsAdmin(Email, Password)));
        }
    }
}
