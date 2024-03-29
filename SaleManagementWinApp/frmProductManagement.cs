using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmProductManagement : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        public frmProductManagement()
        {
            InitializeComponent();
            LoadProduct(GetFlowerBouquets());
        }
        private List<FlowerBouquet> GetFlowerBouquets()
        {
            return productRepository.GetProducts();
        }
        private List<FlowerBouquet> GetFlowerBouquetsUnitInStock()
        {
            return productRepository.GetProductUnitInStock();
        }
        private List<FlowerBouquet> GetFlowerBouquetsByPrice(decimal lowerPrice, decimal upperPrice)
        {
            return productRepository.GetProductsByAmountPrice(lowerPrice, upperPrice);
        }
        private List<FlowerBouquet> GetFlowerBouquetsByUpperPrice(decimal upperPrice)
        {
            return productRepository.GetProductsByUpperPrice(upperPrice);
        }
        private List<FlowerBouquet> GetFlowerBouquetsByLowerPrice(decimal lowerPrice)
        {
            return productRepository.GetProductsByLowerPrice(lowerPrice);
        }
        private FlowerBouquet GetFlowerBouquetsById(int id)
        {
            return productRepository.GetProductById(id);
        }
        private List<FlowerBouquet> GetFlowerBouquetsName(string name)
        {
            return productRepository.GetProductsByName(name);
        }
        private List<FlowerBouquet> GetFlowerBouquetsAscend()
        {
            return productRepository.ArrangeProductAscend();
        }
        private List<FlowerBouquet> GetFlowerBouquetsDecline()
        {
            return productRepository.ArrangeProductDecline();
        }
        public void LoadProduct(List<FlowerBouquet> flowerBouquets)
        {
            BindingSource source = new BindingSource();
            source.DataSource = flowerBouquets;
            DataBindings.Clear();

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = flowerBouquets;
            dgvProductList.ReadOnly = true;
        }
        public void LoadProduct(object sender, EventArgs e)
        {
            var flowerBouquets = GetFlowerBouquets();
            BindingSource source = new BindingSource();
            source.DataSource = flowerBouquets;
            DataBindings.Clear();

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = flowerBouquets;
            dgvProductList.ReadOnly = true;
        }
        private void LoadProductInformation()
        {
            DataGridViewRow row = dgvProductList.CurrentRow;
            txtFlowerBouquetId.Text = row.Cells["FlowerBouquetId"].Value.ToString();
            txtFlowerBouquetName.Text = row.Cells["FlowerBouquetName"].Value.ToString();
            txtFlowerBouquetStatus.Text = row.Cells["FlowerBouquetStatus"].Value.ToString();
            txtFlowerBouquetUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            rtxtFlowerBouquetDescription.Text = row.Cells["Description"].Value.ToString();
            txtFlowerBouquetCategory.Text = row.Cells["CategoryId"].Value.ToString();
            txtFlowerBouquetUnitsInStock.Text = row.Cells["UnitsInStock"].Value.ToString();
            txtSupplierName.Text = row.Cells["SupplierId"].Value.ToString();
        }
        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadProductInformation();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if ((txtSearchValue.Text.Trim().Equals("")) && (txtLowerPrice.Text.Trim().Equals("")) && (txtUpperPrice.Text.Trim().Equals("")))
            {
                LoadProduct(GetFlowerBouquets());
            }
            else if (Validation.IsDecimal(txtLowerPrice.Text.Trim()) || Validation.IsDecimal(txtUpperPrice.Text.Trim()))
            {
                if (txtLowerPrice.Text.Trim().Equals("") && !txtUpperPrice.Text.Trim().Equals(""))
                {
                    LoadProduct(GetFlowerBouquetsByUpperPrice(decimal.Parse(txtUpperPrice.Text.Trim())));
                }
                else if (!txtLowerPrice.Text.Trim().Equals("") && txtUpperPrice.Text.Trim().Equals(""))
                {
                    LoadProduct(GetFlowerBouquetsByLowerPrice(decimal.Parse(txtLowerPrice.Text.Trim())));
                }
                else if (!txtLowerPrice.Text.Trim().Equals("") && !txtUpperPrice.Text.Trim().Equals(""))
                {
                    LoadProduct(GetFlowerBouquetsByPrice(decimal.Parse(txtLowerPrice.Text.Trim()), decimal.Parse(txtUpperPrice.Text.Trim())));
                }
                if (Validation.IsNumberic(txtSearchValue.Text.Trim()))
                {
                    List<FlowerBouquet> flowerBouquets = new List<FlowerBouquet>();
                    flowerBouquets.Add(GetFlowerBouquetsById(int.Parse(txtSearchValue.Text.Trim())));
                    LoadProduct(flowerBouquets);
                }
                else if (!txtSearchValue.Text.Trim().Equals("") && !Validation.IsNumberic(txtSearchValue.Text.Trim()))
                {
                    LoadProduct(GetFlowerBouquetsName(txtSearchValue.Text.Trim()));
                }
            }
        }

        private void cbxShowUnitInStock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowUnitInStock.Checked)
            {
                LoadProduct(GetFlowerBouquetsUnitInStock());
            }
            else
            {
                LoadProduct(GetFlowerBouquets());
            }
        }

        private void btnArrangeIncrease_Click(object sender, EventArgs e)
        {
            LoadProduct(GetFlowerBouquetsAscend());
        }

        private void btnArrangeDecline_Click(object sender, EventArgs e)
        {
            LoadProduct(GetFlowerBouquetsDecline());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProducts frmCreateProducts = new frmCreateProducts();
            frmCreateProducts.Cancel += LoadProduct;
            frmCreateProducts.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFlowerBouquetId.Text.Trim().Equals(""))
            {
                MessageBox.Show("You must choose product to update!", "Product management", MessageBoxButtons.OK);
            }
            else
            {
                if (!txtFlowerBouquetId.Text.Equals(""))
                {
                    frmProductDetail productDetail = new frmProductDetail();
                    productDetail.SetFlowerBouquetId(txtFlowerBouquetId.Text);
                    productDetail.Cancel += LoadProduct;
                    productDetail.ShowDialog();
                }
                else
                {

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProductList.CurrentRow;

            DialogResult d;
            d = MessageBox.Show("Do you really want to delete?", "Product management", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                var change = productRepository.DeleteProduct(int.Parse(row.Cells["FlowerBouquetId"].Value.ToString()));
                if (change)
                {
                    MessageBox.Show("Delete successfully!", "Product management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete!", "Product management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadProduct(GetFlowerBouquets());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
