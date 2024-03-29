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
    public partial class frmCart : Form
    {
        IOrderRepository _orderRepository = new OrderRepository();
        IOrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        IMemberRepository _memberRepository = new MemberRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        public List<OrderDetail> cart { get; set; }
        public Order Order { get; set; }
        public frmCart(List<OrderDetail> cart)
        {
            InitializeComponent();
            LoadCart();
            this.cart = cart;
            lbTotalValue.Text = GetTotalPrice().ToString();
            txtOrderId.Text = AutoGenerateOrderId().ToString();
            txtOrderStatus.Text = "1";
        }


        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RemoveProductFromCart(int flowerId)
        {
            if (cart.Count > 0)
            {
                for (int i = cart.Count - 1; i >= 0; i--)
                {
                    if (cart[i].FlowerBouquetId.Equals(flowerId))
                    {
                        if (cart[i].Quantity > 0)
                        {
                            cart[i].Quantity -= 1;
                            if (cart[i].Quantity == 0)
                            {
                                cart.RemoveAt(i);
                                return;
                            }
                            return;
                        }
                    }
                }
            }
        }
        private void btRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCart.CurrentRow;
            if (cart.Count > 0)
            {
                RemoveProductFromCart(int.Parse(row.Cells["FlowerBouquetId"].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Cannot remove! There is not type of book in cart.", "Create product", MessageBoxButtons.OK);
            }
            LoadCart();
        }
        public void LoadCart() // Make LoadCart public so it can be called from outside
        {
            BindingSource source = new BindingSource();
            source.DataSource = cart;
            DataBindings.Clear();

            dgvCart.DataSource = null;
            dgvCart.DataSource = cart;
        }
        private decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var orderDetail in cart)
            {
                var discount = (decimal)orderDetail.Discount;
                totalPrice += (orderDetail.UnitPrice * orderDetail.Quantity) * (1 - discount);
            }
            return totalPrice;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmCreateOrder frmCreateOrder = new frmCreateOrder();
            frmCreateOrder.cart = cart;
            this.Close();
            frmCreateOrder.Show();
        }
        private int AutoGenerateOrderId()
        {
            using var db = new FStoreDBContext();
            return db.Orders.Max(f => f.OrderId) + 1;
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (_memberRepository.GetCustomerById(int.Parse(txtCustomerId.Text)) != null)
            {
                Order order = new Order()
                {
                    OrderId = AutoGenerateOrderId(),
                    CustomerId = int.Parse(txtCustomerId.Text),
                    OrderDate = DateTime.Now,
                    Total = GetTotalPrice(),
                    OrderStatus = "1",
                };
                var addOrder = _orderRepository.CreateOrder(order);
                if (addOrder)
                {
                    if (_orderDetailRepository.CreateOrderDetail(cart))
                    {
                        cart = new List<OrderDetail>();
                        MessageBox.Show("Your order is created successfully!", "Create order", MessageBoxButtons.OK);
                        LoadCart();
                    }
                    else
                    {
                        MessageBox.Show("Your order is created fail!", "Create order", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid customer!", "Create order", MessageBoxButtons.OK);
            }
            
            
        }
    }
}
