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
    public partial class frmLogin : Form
    {
        private IMemberRepository _memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool IsEmpty()
        {
            return ((txtEmail.Text.Trim().Equals("")) || (txtPassword.Text.Trim().Equals("")));
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if(!IsEmpty())
            {
                var tmp = _memberRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
                if (tmp)
                {
                    frmMain frmMain = new frmMain(txtEmail.Text, txtPassword.Text);
                    MessageBox.Show("Welcome to FStore", "Login", MessageBoxButtons.OK);
                    this.Hide();
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong email or password!", "Login", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Empty fields!", "Login", MessageBoxButtons.OK);
            }
            
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to exit?", "Login", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
