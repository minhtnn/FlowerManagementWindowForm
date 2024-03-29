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
    public partial class frmDetailInfo : Form
    {
        private IMemberRepository _memberRepository = new MemberRepository();
        public string email { get; set; }
        public string password { get; set; }
        public Customer GetCustomer()
        {
            return _memberRepository.GetCustomerByEmailAndPassword(this.email, this.password);
        }
        public Admin GetAdmin()
        {
            return _memberRepository.GetAdmin();
        }
        public frmDetailInfo(string email, string password)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
        }

        private void frmDetailInfo_Load(object sender, EventArgs e)
        {
            ClearInput();
            
        }
        private void LoadMember()
        {
            if (_memberRepository.IsCustomer(this.email, this.password) && (!_memberRepository.IsAdmin(this.email, this.password)))
            {
                Load_Customer();
            }
            if (!(_memberRepository.IsCustomer(this.email, this.password)) && (_memberRepository.IsAdmin(this.email, this.password)))
            {
                Load_Admin();
                btEdit.Enabled = false;
            }
        }
        public void LoadMember(object sender, EventArgs e)
        {
            if (_memberRepository.IsCustomer(this.email, this.password) && (!_memberRepository.IsAdmin(this.email, this.password)))
            {
                Load_Customer();
            }
            if (!(_memberRepository.IsCustomer(this.email, this.password)) && (_memberRepository.IsAdmin(this.email, this.password)))
            {
                Load_Admin();
                btEdit.Enabled = false;
                btnChangePassword.Visible = false;
            }
        }
        private void Load_Customer()
        {
            var customer = GetCustomer();
            txtMemberID.Text = customer.CustomerID.ToString();
            txtMemberName.Text = customer.CustomerName;
            txtMemberEmail.Text = customer.Email.ToString();
            txtMemberCity.Text = customer.City.ToString();
            txtMemberCountry.Text = customer.Country.ToString();
            txtMemberPassword.Text = customer.Password.ToString();
            dtpBirthday.Text = customer.Birthday.ToString();
            txtStatus.Text = customer.CustomerStatus.ToString();
        }
        private void Load_Admin()
        {
            var admin = GetAdmin();
            txtMemberEmail.Text = admin.Email;
            txtMemberPassword.Text = admin.Password;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }
        private bool IsEmptyInput()
        {
            return (txtMemberName.Text.Trim().Equals("")) || (txtMemberEmail.Text.Trim().Equals(""))
            || (txtMemberCity.Text.Trim().Equals("")) || (txtMemberCountry.Text.Trim().Equals(""))
            || (txtMemberPassword.Text.Trim().Equals(""));
        }
        public void EditCustomer()
        {
            if (btEdit.Text.Equals("Edit"))
            {
                btEdit.Text = "Cancel";
                btSave.Enabled = true;
                EnableInput(true);
            }
            else
            {
                btEdit.Text = "Edit";
                btSave.Enabled = false;
                EnableInput(false);
                ClearInput();
                Load_Customer();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {

            if (IsEmptyInput())
            {
                MessageBox.Show("All fields are required!", "View Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Validation.IsNumberic(txtMemberID.Text) && (dtpBirthday.Value < DateTime.Now)
                    && Validation.IsByte(txtStatus.Text))
                {
                    var EditMember = new Customer
                    {
                        CustomerID = int.Parse(txtMemberID.Text),
                        CustomerName = txtMemberName.Text,
                        Email = txtMemberEmail.Text,
                        City = txtMemberCity.Text,
                        Country = txtMemberCountry.Text,
                        Password = txtMemberPassword.Text,
                        Birthday = dtpBirthday.Value,
                        CustomerStatus = byte.Parse(txtStatus.Text),
                    };
                    if (ShowDialogResult("Do you really want to change your profile?", "Detail Information"))
                    {
                        if (_memberRepository.SaveCustomer(EditMember))
                        {
                            MessageBox.Show("Save successfully!");
                            btEdit.Text = "Edit";
                            btSave.Enabled = false;
                            EnableInput(false);

                        }
                        else
                        {
                            MessageBox.Show("Fail to save!");
                        }
                    }
                }
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableInput(bool status)
        {
            txtMemberName.Enabled = status;
            txtMemberEmail.Enabled = status;
            txtMemberCity.Enabled = status;
            txtMemberCountry.Enabled = status;
            dtpBirthday.Enabled = status;
        }
        private void ClearInput()
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            txtMemberEmail.Clear();
            txtMemberCity.Clear();
            txtMemberCountry.Clear();
            txtMemberPassword.Clear();
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ShowDialogResult(string message, string title)
        {
            DialogResult d;
            d = MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            return d == DialogResult.Yes;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordForCustomer frmChangePasswordForCustomer = new frmChangePasswordForCustomer();
            frmChangePasswordForCustomer.Cancel += LoadMember;
            frmChangePasswordForCustomer.ShowDialog();
        }
    }
}
