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
    public partial class frmOrderDetailsFromOrder : Form
    {
        private IOrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        public string email { get; set; }
        public string password { get; set; }
        public int OrderID { get; set; }
        public frmOrderDetailsFromOrder(int orderId)
        {
            this.OrderID = orderId;
            InitializeComponent();
            LoadOrderDetailsByOrderId();
        }
        private List<OrderDetail> GetOrderDetailsByOrderId()
        {
            return _orderDetailRepository.GetOrderDetailsByOrderId(this.OrderID);
        }
        private void LoadOrderDetailsByOrderId()
        {
            var orderList = GetOrderDetailsByOrderId();
            BindingSource source = new BindingSource();
            source.DataSource = orderList;
            DataBindings.Clear();

            dvgOrderDetailsListFromOrder.DataSource = null;
            dvgOrderDetailsListFromOrder.DataSource = orderList;
            dvgOrderDetailsListFromOrder.Columns["OrderId"].Visible = false;
            dvgOrderDetailsListFromOrder.Columns["FlowerBouquet"].Visible = false;
            dvgOrderDetailsListFromOrder.Columns["Order"].Visible = false;
            dvgOrderDetailsListFromOrder.ReadOnly = true;
            //dvgOrderDetailsListFromOrder.Columns["FlowerBouquetId"].Visible = false;
        }
        private void dvgOrderDetailsListFromOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmViewOrdersForCustomer frmViewOrdersForCustomer = new frmViewOrdersForCustomer(this.email, this.password);
            if (frmViewOrdersForCustomer != null)
            {
                this.Close();
            }
        }
    }
}
