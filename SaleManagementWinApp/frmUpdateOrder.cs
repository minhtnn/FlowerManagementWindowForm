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
    public partial class frmUpdateOrder : Form
    {
        private IOrderRepository _orderRepository = new OrderRepository();
        private IMemberRepository _memberRepository = new MemberRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        public int OrderId { get; set; }
        public frmUpdateOrder(int orderId)
        {
            InitializeComponent();
            this.OrderId = orderId;
            LoadOrder();
        }
        public Order GetOrder()
        {
            return _orderRepository.GetOrderById(this.OrderId);
        }
        private bool IsEmptyInput()
        {
            return (txtOrderId.Text.Trim().Equals("")) || (txtCustomerId.Text.Trim().Equals("") ||
                txtOrderStatus.Text.Trim().Equals("") || txtOrderTotal.Text.Trim().Equals("") ||
                dtpOrderDate.Value > DateTime.Now);
        }
        public void LoadOrder()
        {
            var order = GetOrder();
            txtOrderId.Text = this.OrderId.ToString();
            txtCustomerId.Text = order.CustomerId.ToString();
            txtOrderStatus.Text = order.OrderStatus.ToString();
            txtOrderTotal.Text = order.Total.ToString();
            dtpOrderDate.Value = order.OrderDate;
            if (order.ShippedDate != null)
            {
                dtpShippingDate.Value = order.ShippedDate.Value;
            }
            else
            {
                dtpShippingDate.Value = DateTime.Now;
            }
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            
            if (IsEmptyInput())
            {
                MessageBox.Show("All fields are required!", "Update order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Validation.CheckStartEndDate(dtpOrderDate.Value, DateTime.Now) &&
                    Validation.IsDecimal(txtOrderTotal.Text) && Validation.IsNumberic(txtCustomerId.Text)
                   && (_memberRepository.GetCustomerById(int.Parse(txtCustomerId.Text)) != null))
                {
                    var order1 = GetOrder();
                    Order order = new Order()
                    {
                        OrderId = this.OrderId,
                        CustomerId = int.Parse(txtCustomerId.Text),
                        OrderDate = dtpOrderDate.Value,
                        ShippedDate = dtpShippingDate.Value,
                        Total = decimal.Parse(txtOrderTotal.Text),
                        OrderStatus = txtOrderStatus.Text,
                        Customer = order1.Customer,
                        OrderDetails = order1.OrderDetails,
                    };
                    var change = _orderRepository.UpdateOrder(order);
                    if (change)
                    {
                        MessageBox.Show("Your order is updated successfully!", "Update order", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Your order is updated failed!", "Update order", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Some invalid fields!", "Update order", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }
    }
}
