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
    public partial class frmOrders : Form
    {
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        private List<Order> GetOrders()
        {
            return orderRepository.GetOrders();
        }
        private List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return orderDetailRepository.GetOrderDetailsByOrderId(orderId);
        }
        public frmOrders()
        {
            InitializeComponent();
            LoadOrder();
            LoadOrderInformation();
        }
        private void LoadOrder()
        {
            BindingSource source = new BindingSource();
            source.DataSource = GetOrders();
            DataBindings.Clear();

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = GetOrders();
            dgvOrderList.ReadOnly = true;
            dgvOrderList.Columns["Customer"].Visible = false;
            dgvOrderList.Columns["OrderDetails"].Visible = false;
        }
        private void LoadOrder(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = GetOrders();
            DataBindings.Clear();

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = GetOrders();
            dgvOrderList.ReadOnly = true;
            dgvOrderList.Columns["Customer"].Visible = false;
            dgvOrderList.Columns["OrderDetails"].Visible = false;
        }
        private void LoadOrderInformation()
        {
            DataGridViewRow row = dgvOrderList.CurrentRow;
            if (row != null)
            {
                txtOrderId.Text = row.Cells["OrderId"].Value.ToString();
                txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                txtOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
                txtOrderTotal.Text = row.Cells["Total"].Value.ToString();
                dtpOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
                dtpShippingDate.Text = row.Cells["ShippedDate"].Value.ToString();
                LoadOrderDetailsByOrderId(int.Parse(row.Cells["OrderId"].Value.ToString()));
            }
        }
        private void LoadOrderDetailsByOrderId(int orderId)
        {
            BindingSource source = new BindingSource();
            source.DataSource = GetOrderDetailsByOrderId(orderId);
            DataBindings.Clear();

            dgvOrderDetailsOfOrder.DataSource = null;
            dgvOrderDetailsOfOrder.DataSource = GetOrderDetailsByOrderId(orderId);
            dgvOrderDetailsOfOrder.ReadOnly = true;
            dgvOrderDetailsOfOrder.Columns["OrderId"].Visible = false;
            dgvOrderDetailsOfOrder.Columns["FlowerBouquet"].Visible = false;
            dgvOrderDetailsOfOrder.Columns["Order"].Visible = false;
        }
        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvOrderList.Rows[e.RowIndex];
                if (row != null)
                {
                    txtOrderId.Text = row.Cells["OrderId"].Value.ToString();
                    txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                    txtOrderStatus.Text = row.Cells["OrderStatus"].Value.ToString();
                    txtOrderTotal.Text = row.Cells["Total"].Value.ToString();
                    dtpOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
                    if (row.Cells["ShippedDate"].Value != null)
                    {
                        dtpShippingDate.Text = row.Cells["ShippedDate"].Value.ToString();
                    }
                    else
                    {
                        dtpShippingDate.Text = null;
                    }
                    LoadOrderDetailsByOrderId(int.Parse(row.Cells["OrderId"].Value.ToString()));
                }
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            frmCreateOrder frmCreateOrder = new frmCreateOrder();
            frmCreateOrder.ShowDialog();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!txtOrderId.Text.Trim().Equals("") || txtOrderId.Text == null)
            {
                frmUpdateOrder frmUpdateOrder = new frmUpdateOrder(int.Parse(txtOrderId.Text));
                frmUpdateOrder.OrderId = int.Parse(txtOrderId.Text);
                frmUpdateOrder.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must choose order to update!", "Orders", MessageBoxButtons.OK);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text.Trim().Equals(""))
            {
                MessageBox.Show("You must choose order to delete!", "Orders", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete?", "Order management"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (d == DialogResult.Yes)
                {
                    var change = orderRepository.DeleteOrder(int.Parse(txtOrderId.Text));
                    if (change)
                    {
                        MessageBox.Show("Delete successfully!", "Orders", MessageBoxButtons.OK);
                        LoadOrder();
                    }
                    else
                    {
                        MessageBox.Show("Delete fail!", "Orders", MessageBoxButtons.OK);
                    }
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
