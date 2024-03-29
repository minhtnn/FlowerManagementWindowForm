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

    public partial class frmChangePasswordForCustomer : Form
    {
        private IMemberRepository _memberRepository = new MemberRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        public int CustomerId { get; set; }
        public frmChangePasswordForCustomer()
        {
            InitializeComponent();
        }
        private bool IsEmpty()
        {
            return (txtConfirmPassword.Text.Trim().Equals("") || (txtNewPassword.Text.Trim().Equals("")
                || (txtOldPassword.Text.Trim().Equals(""))));
        }
        private void btChangePassword_Click(object sender, EventArgs e)
        {
            var customer = _memberRepository.GetCustomerById(this.CustomerId);
            if (!IsEmpty())
            {
                if (txtOldPassword.Text.Trim().Equals(customer.Password))
                {
                    if (txtNewPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()))
                    {
                        Customer customer1 = new Customer()
                        {
                            CustomerID = customer.CustomerID,
                            Password = txtNewPassword.Text,
                            Email = customer.Email,
                            Birthday = customer.Birthday,
                            CustomerName = customer.CustomerName,
                            City = customer.City,
                            Country = customer.Country,
                            CustomerStatus = customer.CustomerStatus,
                            Orders = customer.Orders
                        };
                        DialogResult d;
                        d = MessageBox.Show("Do you really want to change password?", "Change password",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (d == DialogResult.Yes)
                        {
                            if (_memberRepository.SaveCustomer(customer1))
                            {
                                MessageBox.Show("Save successfully!", "Change password",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Cancel?.Invoke(this, new EventArgs());
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Fail to save!", "Change password",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirm password does not match new password!", "Change password",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password!", "Change password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required!", "Change password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }
    }
}
