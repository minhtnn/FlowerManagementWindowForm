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
    public partial class frmReport : Form
    {
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private IMemberRepository memberRepository = new MemberRepository();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadStatisticReport();
            LoadOrderDetail(orderDetailRepository.GetOrderDetailsInPeriodTime(dtpStartDate.Value, dtpEndDate.Value));
        }
        private void LoadStatisticReport()
        {
            txtTotalOrders.Text = orderRepository.GetOrderQuantity(dtpStartDate.Value, dtpEndDate.Value).ToString();
            txtTotalRevenue.Text = orderRepository.GetTotalRevenue(dtpStartDate.Value, dtpEndDate.Value).ToString();
            txtTotalSoldProduct.Text = orderDetailRepository.GetTotalSoldProduct(dtpStartDate.Value, dtpEndDate.Value).ToString();
            txtTotalCustomers.Text = memberRepository.GetCustomers().Count().ToString();
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value.Date <= dtpEndDate.Value.Date)
            {
                LoadStatisticReport();
                LoadOrderDetail(orderDetailRepository.GetOrderDetailsInPeriodTime(dtpStartDate.Value, dtpEndDate.Value));
            }
            else
            {
                MessageBox.Show("Invalid period of day!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value.Date <= dtpEndDate.Value.Date)
            {
                LoadStatisticReport();
                LoadOrderDetail(orderDetailRepository.GetOrderDetailsInPeriodTime(dtpStartDate.Value, dtpEndDate.Value));
            }
            else
            {
                MessageBox.Show("Invalid period of day!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadOrderDetail(List<OrderDetail> orderDetails)
        {
            BindingSource source = new BindingSource();
            source.DataSource = orderDetails;
            DataBindings.Clear();

            dgvOrderDetailsList.DataSource = null;
            dgvOrderDetailsList.DataSource = orderDetails;
            dgvOrderDetailsList.ReadOnly = true;
        }
        private void dgvOrderDetailsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
