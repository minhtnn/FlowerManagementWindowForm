using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmCustomerManagement : Form
    {
        IMemberRepository _memberRepository = new MemberRepository();
        public frmCustomerManagement()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private List<Customer> GetCustomers()
        {
            return _memberRepository.GetCustomers();
        }
        public void LoadCustomers()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = GetCustomers();
            DataBindings.Clear();

            txtCustomerId.DataBindings.Add("Text", bindingSource, "CustomerID");
            txtCustomerName.DataBindings.Add("Text", bindingSource, "CustomerName");
            txtCustomerEmail.DataBindings.Add("Text", bindingSource, "Email");
            txtCustomerPassword.DataBindings.Add("Text", bindingSource, "Password");
            txtCustomerCity.DataBindings.Add("Text", bindingSource, "City");
            txtCustomerCountry.DataBindings.Add("Text", bindingSource, "Country");
            txtCustomerStatus.DataBindings.Add("Text", bindingSource, "CustomerStatus");
            dtcCustomerBirthday.DataBindings.Add("Text", bindingSource, "Birthday");

            dgvCustomerList.DataSource = null;
            dgvCustomerList.DataSource = GetCustomers();
            dgvCustomerList.ReadOnly = true;
            dgvCustomerList.Columns["Orders"].Visible = false;
        }
        public void LoadCustomers(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = GetCustomers();
            DataBindings.Clear();

            

            dgvCustomerList.DataSource = null;
            dgvCustomerList.DataSource = GetCustomers();
            dgvCustomerList.ReadOnly = true;
            dgvCustomerList.Columns["Orders"].Visible = false;
        }
        private void LoadCustomersInformation()
        {
            //DataGridViewRow row = dgvCustomerList.CurrentRow;
            //    txtCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
            //    txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
            //    txtCustomerEmail.Text = row.Cells["Email"].Value.ToString();
            //    txtCustomerPassword.Text = row.Cells["Password"].Value.ToString();
            //    txtCustomerCity.Text = row.Cells["City"].Value.ToString();
            //    txtCustomerCountry.Text = row.Cells["Country"].Value.ToString();
            //    txtCustomerStatus.Text = row.Cells["CustomerStatus"].Value.ToString();
            //    dtcCustomerBirthday.Text = row.Cells["Birthday"].Value.ToString();
        }
        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCustomerList.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["Email"].Value.ToString();
                txtCustomerPassword.Text = row.Cells["Password"].Value.ToString();
                txtCustomerCity.Text = row.Cells["City"].Value.ToString();
                txtCustomerCountry.Text = row.Cells["Country"].Value.ToString();
                txtCustomerStatus.Text = row.Cells["CustomerStatus"].Value.ToString();
                dtcCustomerBirthday.Text = row.Cells["Birthday"].Value.ToString();
            }
        }

        private void EnableText(bool status)
        {
            txtCustomerId.Enabled = status;
            txtCustomerName.Enabled = status;
            txtCustomerEmail.Enabled = status;
            txtCustomerPassword.Enabled = status;
            txtCustomerCity.Enabled = status;
            txtCustomerCountry.Enabled = status;
            dtcCustomerBirthday.Enabled = status;
        }
        private void ClearText()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerCountry.Text = "";
            txtCustomerPassword.Text = "";
            dtcCustomerBirthday.Text = "";
        }
        private void FillText()
        {

        }
        private bool CheckTextIsEmpty()
        {
            return (txtCustomerId.Text.Trim().Equals("") || txtCustomerName.Text.Trim().Equals("")
                || txtCustomerPassword.Text.Trim().Equals("") || txtCustomerCity.Text.Trim().Equals("")
                || txtCustomerCountry.Text.Trim().Equals("") || txtCustomerEmail.Text.Trim().Equals(""));
        }
        public void ClearDataBinding()
        {
            txtCustomerId.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            txtCustomerEmail.DataBindings.Clear();
            txtCustomerCity.DataBindings.Clear();
            txtCustomerCountry.DataBindings.Clear();
            txtCustomerPassword.DataBindings.Clear();
            dtcCustomerBirthday.DataBindings.Clear();
            txtCustomerStatus.DataBindings.Clear();
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer frmAddNewCustomer = new frmAddNewCustomer();
            frmAddNewCustomer.Cancel += LoadCustomers;
            frmAddNewCustomer.ShowDialog();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (btUpdate.Text.Equals("Cancel"))
            {
                if (CheckTextIsEmpty())
                {
                    MessageBox.Show("All fields are required", "Customer management", MessageBoxButtons.OK);
                }
                else
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = int.Parse(txtCustomerId.Text),
                        CustomerName = txtCustomerName.Text,
                        Email = txtCustomerEmail.Text,
                        City = txtCustomerCity.Text,
                        Country = txtCustomerCountry.Text,
                        Birthday = DateTime.Parse(dtcCustomerBirthday.Text),
                        Password = txtCustomerPassword.Text,
                        CustomerStatus = Byte.Parse(txtCustomerStatus.Text),
                    };
                    var check = _memberRepository.SaveCustomer(customer);
                    if (check)
                    {
                        MessageBox.Show("Update successfully!", "Customer management", MessageBoxButtons.OK);

                        btUpdate.Text = "Update";
                        btCreate.Enabled = true;
                        btDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update!", "Customer management", MessageBoxButtons.OK);
                    }

                }

            }
            LoadCustomers();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!txtCustomerId.Text.Trim().Equals(""))
            {
                frmUpdateCustomer frmUpdateCustomer = new frmUpdateCustomer(int.Parse(txtCustomerId.Text));
                frmUpdateCustomer.Cancel += LoadCustomers;
                frmUpdateCustomer.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose customer to update!", "Customer management", MessageBoxButtons.OK);
            }
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you want to delete?", "Customer management",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var check = _memberRepository.DeleteCustomerById(int.Parse(txtCustomerId.Text));
                if (check)
                {
                    MessageBox.Show("Delete successfully!", "Customer management", MessageBoxButtons.OK);
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Failed to delete!", "Customer management", MessageBoxButtons.OK);
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
