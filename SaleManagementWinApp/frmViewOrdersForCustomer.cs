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
    public partial class frmViewOrdersForCustomer : Form
    {
        private IOrderRepository _orderRepository = new OrderRepository();
        private IMemberRepository _memberRepository = new MemberRepository();
        private IOrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        public string email { get; set; }
        public string password { get; set; }
        public Customer GetCustomer()
        {
            return _memberRepository.GetCustomerByEmailAndPassword(this.email, this.password);
        }
        public frmViewOrdersForCustomer(string email, string password)
        {
            InitializeComponent();

            this.email = email;
            this.password = password;
            LoadCustomerOrderList();
        }
        public void LoadCustomerOrderList()
        {
            var orderList = _orderRepository.GetOrdersByCustomerID(GetCustomer().CustomerID);
            BindingSource source = new BindingSource();
            source.DataSource = orderList;
            DataBindings.Clear();

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = orderList;
            dgvOrderList.Columns["CustomerId"].Visible = false;
            dgvOrderList.Columns["OrderDetails"].Visible = false;
            dgvOrderList.Columns["Customer"].Visible = false;
            dgvOrderList.ReadOnly = true;
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrderList.Rows[e.RowIndex];
                txtOrderId.Text = row.Cells["OrderId"].Value.ToString();
                dtpOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
                dtpShippingDate.Text = row.Cells["ShippedDate"].Value.ToString();
                txtOrderTotal.Text = row.Cells["Total"].Value.ToString();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btViewOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgvOrderList.CurrentRow;
                DataGridViewCell valueCell = selectedRow.Cells["OrderId"];
                if (valueCell != null)
                {
                    int orderId = Convert.ToInt32(valueCell.Value);
                    frmOrderDetailsFromOrder frmOrderDetailsFromOrder = new frmOrderDetailsFromOrder(orderId);
                    frmOrderDetailsFromOrder.email = this.email;
                    frmOrderDetailsFromOrder.password = this.password;
                        frmOrderDetailsFromOrder.ShowDialog();
                }
            }
        }
    }
}
