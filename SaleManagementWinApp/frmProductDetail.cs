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
    public partial class frmProductDetail : Form
    {
        private ICategoryRepository _categoryRepository = new CategoryRepository();
        private ISupplierRepository _supplierRepository = new SupplierRepository();
        private IProductRepository _productRepository = new ProductRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        private string flowerBouquetId;
        public void SetFlowerBouquetId(string flowerBouquetId)
        {
            this.flowerBouquetId = flowerBouquetId;
        }
        public string GetFlowerBouquetId()
        {
            return this.flowerBouquetId;
        }

        public frmProductDetail()
        {
            InitializeComponent();
            
            
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
                cmbCategory.Items.Add(category.CategoryName);
            }
        }
        private void LoadSupplierIntoComboBox()
        {
            foreach (var supplier in GetSupplier())
            {
                cmbSupplier.Items.Add(supplier.SupplierName);
            }
        }
        public void LoadProduct()
        {
            ClearInput();
            FlowerBouquet flowerBouquet = _productRepository.GetProductById(int.Parse(this.flowerBouquetId));
            txtFlowerBouquetId.Text = flowerBouquet.FlowerBouquetId.ToString();
            txtFlowerBouquetName.Text = flowerBouquet.FlowerBouquetName;
            txtFlowerBouquetDescription.Text = flowerBouquet.Description;
            txtFlowerBouquetStatus.Text = flowerBouquet.FlowerBouquetStatus.ToString();
            txtFlowerBouquetUnitPrice.Text = flowerBouquet.UnitPrice.ToString();
            txtFlowerBouquetUnitsInStock.Text = flowerBouquet.UnitsInStock.ToString();
            txtFlowerBouquetMorphology.Text = flowerBouquet.Morphology;
            LoadCategoryIntoComboBox();
            LoadSupplierIntoComboBox();
            cmbCategory.Text = _categoryRepository.GetCategoryById(flowerBouquet.CategoryId).CategoryName; 
            cmbSupplier.Text = _supplierRepository.GetSupplierById(flowerBouquet.SupplierId).SupplierName;
            
        }
        public void ClearInput()
        {
            txtFlowerBouquetId.Text = "";
            txtFlowerBouquetName.Text = "";
            txtFlowerBouquetDescription.Text = "";
            txtFlowerBouquetStatus.Text = "";
            txtFlowerBouquetUnitPrice.Text = "";
            txtFlowerBouquetUnitsInStock.Text = "";
            txtFlowerBouquetMorphology.Text = "";
            cmbCategory.Text = "";
            cmbSupplier.Text = "";
        }
        public bool IsEmptyInput()
        {
            return (txtFlowerBouquetName.Text.Trim().Equals("") || (txtFlowerBouquetStatus.Text.Trim().Equals(""))
                || (txtFlowerBouquetUnitPrice.Text.Trim().Equals("")) || (txtFlowerBouquetUnitsInStock.Text.Trim().Equals("")));
        }
        private void btnUpdate_Click(object sender, EventArgs e)
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
                        CategoryId = _categoryRepository.GetCategoryByName(cmbCategory.Text as string).CategoryId,
                        Description = txtFlowerBouquetDescription.Text,
                        Morphology = txtFlowerBouquetMorphology.Text,
                        SupplierId = _supplierRepository.GetSupplierByName(cmbSupplier.SelectedItem as string).SupplierId,
                        FlowerBouquetStatus = byte.Parse(txtFlowerBouquetStatus.Text),
                        UnitsInStock = int.Parse(txtFlowerBouquetUnitsInStock.Text),
                    };
                    if (_productRepository.UpdateProduct(flowerBouquet))
                    {
                        MessageBox.Show("Update successfully", "Product detail", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Fail to update", "Product detail", MessageBoxButtons.OK);
                    }
                }
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
