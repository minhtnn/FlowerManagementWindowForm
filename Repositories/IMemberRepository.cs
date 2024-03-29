using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMemberRepository
    {
        bool CheckLogin(string username, string password);
        bool IsCustomer(string CustomerEmail, string password);
        List<Customer> GetCustomers();
        Customer GetCustomerById(int CustomerID);
        Customer GetCustomerByEmailAndPassword(String? Email, String? Password);
        int AutoGenerateCustomerId();
        bool SaveCustomer(Customer customer);
        bool DeleteCustomerById(int customerId);
        bool AddCustomer(Customer customer);
        bool IsAdmin(string Email, string Password);
        Admin GetAdmin();
    }
}
