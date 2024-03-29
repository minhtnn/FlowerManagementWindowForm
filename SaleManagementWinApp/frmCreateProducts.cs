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
    public partial class frmCreateProducts : Form
    {
        private ICategoryRepository _categoryRepository = new CategoryRepository();
        private ISupplierRepository _supplierRepository = new SupplierRepository();
        private IProductRepository _productRepository = new ProductRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        public frmCreateProducts()
        {
            InitializeComponent();
            LoadCategoryIntoComboBox();
            LoadSupplierIntoComboBox();
            txtFlowerBouquetId.Text = AutoGenerateProductId().ToString();
            cmbFlowerBouquetCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
        }
        private List<Category> GetCategory()
        {
            return _categoryRepository.GetCategories();
        }
        private List<Supplier> GetSupplier()
        {
            return _supplierRepository.GetSuppliers();
        }
        private void LoadCategoryIntoComboBox()
        {
            foreach (var category in GetCategory())
            {
                cmbFlowerBouquetCategory.Items.Add(category.CategoryName);
            }
        }
        private void LoadSupplierIntoComboBox()
        {
            foreach (var supplier in GetSupplier())
            {
                cmbSupplier.Items.Add(supplier.SupplierName);
            }
        }
        private void cmbFlowerBouquetCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int AutoGenerateProductId()
        {
            return _productRepository.GetProducts().Count + 1;
        }
        public bool IsEmptyInput()
        {
            return (txtFlowerBouquetName.Text.Trim().Equals("") || (txtFlowerBouquetStatus.Text.Trim().Equals(""))
                || (txtFlowerBouquetUnitPrice.Text.Trim().Equals("")) || (txtUnitInStock.Text.Trim().Equals("")));
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsEmptyInput())
            {
                MessageBox.Show("All fields are required!", "Create product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Validation.IsByte(txtFlowerBouquetStatus.Text))
                {
                    FlowerBouquet flowerBouquet = new FlowerBouquet()
                    {
                        FlowerBouquetId = int.Parse(txtFlowerBouquetId.Text),
                        FlowerBouquetName = txtFlowerBouquetName.Text,
                        UnitPrice = decimal.Parse(txtFlowerBouquetUnitPrice.Text),
                        CategoryId = _categoryRepository.GetCategoryByName(cmbFlowerBouquetCategory.Text as string).CategoryId,
                        Description = rtxFlowerBouquetDescription.Text,
                        Morphology = rtxFlowerBouquetMorphology.Text,
                        SupplierId = _supplierRepository.GetSupplierByName(cmbSupplier.SelectedItem as string).SupplierId,
                        FlowerBouquetStatus = byte.Parse(txtFlowerBouquetStatus.Text),
                        UnitsInStock = int.Parse(txtUnitInStock.Text),
                    };
                    if (_productRepository.CreateProduct(flowerBouquet))
                    {
                        MessageBox.Show("Create successfully", "Create product", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Fail to create", "Create product", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Some invalid field", "Create product", MessageBoxButtons.OK);
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
