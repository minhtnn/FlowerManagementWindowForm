using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public bool CheckLogin(string username, string password)
            =>MemberDAO.Instance.CheckLogin(username, password);

        public List<Customer> GetCustomers()
            => MemberDAO.Instance.GetCustomers();
        public Customer GetCustomerById(int CustomerID)
            => MemberDAO.Instance.GetCustomerById(CustomerID);
        public Customer GetCustomerByEmailAndPassword(String? Email, String? Password)
            => MemberDAO.Instance.GetCustomerByEmailAndPassword(Email, Password);
        public bool SaveCustomer(Customer customer)
            => MemberDAO.Instance.SaveCustomer(customer);

        public bool IsCustomer(string Email, string password)
            => MemberDAO.Instance.IsCustomer(Email, password);

        public bool IsAdmin(string Email, string Password)
            => MemberDAO.Instance.IsAdmin(Email, Password);

        public Admin GetAdmin()
            => MemberDAO.Instance.GetAdmin();

        public bool DeleteCustomerById(int customerId)
            => MemberDAO.Instance.DeleteCustomerById(customerId);

        public bool AddCustomer(Customer customer)
            => MemberDAO.Instance.AddCustomer(customer);

        public int AutoGenerateCustomerId()
            => MemberDAO.Instance.AutoGenerateCustomerId();
    }
}
