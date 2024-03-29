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
using static System.Net.Mime.MediaTypeNames;

namespace SaleManagementWinApp
{
    public partial class frmAddNewCustomer : Form
    {
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        private IMemberRepository _memberRepository = new MemberRepository();
        public frmAddNewCustomer()
        {
            InitializeComponent();
            LoadInformation();
        }   
        private void LoadInformation()
        {
            txtCustomerId.Text = _memberRepository.AutoGenerateCustomerId().ToString();
            txtCustomerStatus.Text = "1";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }
        private bool IsEmptyInput()
        {
            return (txtCustomerName.Text.Trim().Equals("")) || (txtCustomerPassword.Text.Trim().Equals("")
                || (txtCustomerStatus.Text.Trim().Equals("")) || (dtcCustomerBirthday.Value >= DateTime.Now));
        }
        
        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyInput())
            {
                if (Validation.IsMail(txtCustomerEmail.Text))
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = int.Parse(txtCustomerId.Text),
                        CustomerName = txtCustomerName.Text,
                        Email = txtCustomerEmail.Text,
                        CustomerStatus = 1,
                        Password = txtCustomerPassword.Text,
                        City = txtCustomerCity.Text,
                        Country = txtCustomerCountry.Text,
                        Birthday = dtcCustomerBirthday.Value,
                    };
                    var add = _memberRepository.AddCustomer(customer);
                    if (add)
                    {
                        MessageBox.Show("Create successfully!", "Add new customer", MessageBoxButtons.OK);
                        LoadInformation();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create!", "Add new customer", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong email format!", "Add new customer", MessageBoxButtons.OK);
                }
                
            }else
            {
                MessageBox.Show("All fields are required!", "Add new customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
