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
    public partial class frmMain : Form
    {
        private IMemberRepository _memberRepository = new MemberRepository();
        public string email { get; set; }
        public string password { get; set; }
        public Customer GetCustomer()
        {
            return _memberRepository.GetCustomerByEmailAndPassword(email, password);
        }
        public frmMain(string email, string password)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
            if (_memberRepository.IsAdmin(this.email, this.password) && !_memberRepository.IsCustomer(this.email, this.password))
            {
                adminToolStripMenuItem.Visible = true;
                customerToolStripMenuItem.Visible = false;
            }
            else
            {
                customerToolStripMenuItem.Visible = true;
                adminToolStripMenuItem.Visible = false;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
        }
        private void btViewProfile_Click(object sender, EventArgs e)
        {
            frmDetailInfo frmDetailInfo = new frmDetailInfo(email, password);
            frmDetailInfo.email = email;
            frmDetailInfo.password = password;
            this.Hide();
            frmDetailInfo.ShowDialog();

        }

        private void btViewOrderHistory_Click(object sender, EventArgs e)
        {
            frmViewOrdersForCustomer frmViewOrdersForCustomer = new frmViewOrdersForCustomer(this.email, this.password);
            this.Hide();
            frmViewOrdersForCustomer.ShowDialog();

        }

        private void productMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement();
            frmProductManagement.MdiParent = this;
            frmProductManagement.Show();
        }

        private void orderManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders();
            frmOrders.MdiParent = this;
            frmOrders.Show();
        }

        private void customerManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomerManagement frmCustomerManagement = new frmCustomerManagement();
            frmCustomerManagement.MdiParent = this;
            frmCustomerManagement.Show();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetailInfo frmDetailInfo = new frmDetailInfo(this.email, this.password);
            frmDetailInfo.MdiParent = this;
            frmDetailInfo.Show();
        }

        private void viewProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetailInfo frmDetailInfo = new frmDetailInfo(this.email, this.password);
            frmDetailInfo.MdiParent = this;
            frmDetailInfo.Show();
        }

        private void viewOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewOrdersForCustomer frmViewOrdersForCustomer = new frmViewOrdersForCustomer(this.email, this.password);
            frmViewOrdersForCustomer.MdiParent = this;
            frmViewOrdersForCustomer.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to log out?", "Log out", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                if (frmLogin != null)
                {
                    this.Close();
                    frmLogin.Show();
                }
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.MdiParent = this;
            frmReport.Show();
        }
    }
}
