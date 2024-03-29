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
    public partial class frmCreateOrder : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private IMemberRepository memberRepository = new MemberRepository();
        public List<OrderDetail> cart { get; set; }
        public frmCreateOrder()
        {
            InitializeComponent();
            LoadProducts();
        }
        private List<FlowerBouquet> GetProductUnitInStock()
        {
            return productRepository.GetProductUnitInStock();
        }
        private List<FlowerBouquet> GetProductByName(string name)
        {
            return productRepository.GetProductsByName(name);
        }
        private void LoadProducts()
        {
            BindingSource source = new BindingSource();
            source.DataSource = GetProductUnitInStock();
            DataBindings.Clear();

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = GetProductUnitInStock();
            dgvProductList.Columns["CategoryId"].Visible = false;
            dgvProductList.Columns["FlowerBouquetStatus"].Visible = false;
            dgvProductList.Columns["SupplierId"].Visible = false;
            dgvProductList.Columns["Morphology"].Visible = false;
            dgvProductList.Columns["Category"].Visible = false;
            dgvProductList.Columns["Supplier"].Visible = false;
            dgvProductList.Columns["OrderDetails"].Visible = false;

            dgvProductList.ReadOnly = true;
        }
        private void LoadProductByName(string name)
        {
            BindingSource source = new BindingSource();
            source.DataSource = GetProductUnitInStock();
            DataBindings.Clear();

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = GetProductUnitInStock();
            dgvProductList.Columns["CategoryId"].Visible = false;
            dgvProductList.Columns["FlowerBouquetStatus"].Visible = false;
            dgvProductList.Columns["SupplierId"].Visible = false;
            dgvProductList.Columns["Morphology"].Visible = false;
            dgvProductList.Columns["Category"].Visible = false;
            dgvProductList.Columns["Supplier"].Visible = false;
            dgvProductList.Columns["OrderDetails"].Visible = false;

            dgvProductList.ReadOnly = true;
        }
        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            LoadProductByName(txtSearchProduct.Text);
        }
        private int AutoGenerateOrderId()
        {
            using var db = new FStoreDBContext();
            return db.Orders.Max(f => f.OrderId) + 1;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProductList.CurrentRow;
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = AutoGenerateOrderId(),
                FlowerBouquetId = int.Parse(row.Cells["FlowerBouquetId"].Value.ToString()),
                Quantity = 1,
                Discount = 0,
                UnitPrice = decimal.Parse(row.Cells["UnitPrice"].Value.ToString()),
            };
            AddProductToCart(orderDetail);

        }
        private void InitializeCart()
        {
            if (cart == null)
            {
                cart = new List<OrderDetail>();
            }
        }
        private void AddProductToCart(OrderDetail orderDetail)
        {
            InitializeCart();
            if (cart.Count > 0)
            {
                foreach (var flowerItem in cart)
                {
                    if (flowerItem.FlowerBouquetId.Equals(orderDetail.FlowerBouquetId))
                    {
                        flowerItem.Quantity += orderDetail.Quantity;
                        return;
                    }
                }
                cart.Add(orderDetail);
            }
            else
            {
                cart.Add(orderDetail);
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (cart != null && cart.Count > 0)
            {
                frmCart frmCart = new frmCart(cart);
                frmCart.cart = cart;
                frmCart.LoadCart();
                this.Hide();
                frmCart.ShowDialog();
            }
            else
            {

                MessageBox.Show("Cart is empty.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
