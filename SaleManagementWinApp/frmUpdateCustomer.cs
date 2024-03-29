using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmUpdateCustomer : Form
    {
        IMemberRepository _memberRepository = new MemberRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        public int CustomerID { get; set; }
        public frmUpdateCustomer(int customerId)
        {
            InitializeComponent();
            CustomerID = customerId;
            LoadCustomer();
        }
        public Customer GetCustomer()
        {
            return _memberRepository.GetCustomerById(this.CustomerID);
        }
        public void LoadCustomer()
        {
            Customer customer = GetCustomer();
            txtCustomerId.Text = this.CustomerID.ToString();
            txtCustomerName.Text = customer.CustomerName;
            txtCustomerPassword.Text = customer.Password;
            txtCustomerEmail.Text = customer.Email;
            txtCustomerCity.Text = customer.City;
            txtCustomerCountry.Text = customer.Country;
            txtCustomerStatus.Text = customer.CustomerStatus.ToString();
            dtcCustomerBirthday.Value = customer.Birthday.Value;
        }
        private bool IsEmptyInput()
        {
            return (txtCustomerName.Text.Trim().Equals("")) || (txtCustomerPassword.Text.Trim().Equals("")
                || (txtCustomerStatus.Text.Trim().Equals("")) || (dtcCustomerBirthday.Value >= DateTime.Now));
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyInput())
            {
                if (Validation.IsByte(txtCustomerStatus.Text) && dtcCustomerBirthday.Value < DateTime.Now)
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = this.CustomerID,
                        CustomerName = txtCustomerName.Text,
                        Email = txtCustomerEmail.Text,
                        CustomerStatus = byte.Parse(txtCustomerStatus.Text),
                        Password = txtCustomerPassword.Text,
                        City = txtCustomerCity.Text,
                        Country = txtCustomerCountry.Text,
                        Birthday = dtcCustomerBirthday.Value,
                    };
                    var update = _memberRepository.SaveCustomer(customer);
                    if (update)
                    {
                        MessageBox.Show("Update successfully!", "Update customer", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update!", "Update customer", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input fields!", "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required!", "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }
    }
}
