namespace SaleManagementWinApp
{
    partial class frmProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFlowerBouquetId = new Label();
            lbFlowerBouquetName = new Label();
            lbFlowerBouquetCategory = new Label();
            lbFlowerBouquetDescription = new Label();
            lbFlowerBouquetUnitsInStock = new Label();
            lbFlowerBouquetStatus = new Label();
            lbFlowerBouquetSupplierId = new Label();
            lbFlowerBouquetUnitPrice = new Label();
            lbFlowerBouquetMorphology = new Label();
            txtFlowerBouquetId = new TextBox();
            txtFlowerBouquetName = new TextBox();
            txtFlowerBouquetCategory = new TextBox();
            txtFlowerBouquetUnitsInStock = new TextBox();
            rtxtFlowerBouquetDescription = new RichTextBox();
            txtFlowerBouquetUnitPrice = new TextBox();
            txtSupplierName = new TextBox();
            txtFlowerBouquetStatus = new TextBox();
            txtFlowerBouquetMorphology = new TextBox();
            dgvProductList = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            lbSearch = new Label();
            lbInPriceAmount = new Label();
            txtSearchValue = new TextBox();
            txtLowerPrice = new TextBox();
            txtUpperPrice = new TextBox();
            lbConnect = new Label();
            cbxShowUnitInStock = new CheckBox();
            btSearch = new Button();
            lbArrangeBy = new Label();
            btnArrangeDecline = new Button();
            btnArrangeIncrease = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // lbFlowerBouquetId
            // 
            lbFlowerBouquetId.AutoSize = true;
            lbFlowerBouquetId.Location = new Point(38, 39);
            lbFlowerBouquetId.Name = "lbFlowerBouquetId";
            lbFlowerBouquetId.Size = new Size(75, 20);
            lbFlowerBouquetId.TabIndex = 0;
            lbFlowerBouquetId.Text = "Flower ID:";
            // 
            // lbFlowerBouquetName
            // 
            lbFlowerBouquetName.AutoSize = true;
            lbFlowerBouquetName.Location = new Point(38, 84);
            lbFlowerBouquetName.Name = "lbFlowerBouquetName";
            lbFlowerBouquetName.Size = new Size(52, 20);
            lbFlowerBouquetName.TabIndex = 1;
            lbFlowerBouquetName.Text = "Name:";
            // 
            // lbFlowerBouquetCategory
            // 
            lbFlowerBouquetCategory.AutoSize = true;
            lbFlowerBouquetCategory.Location = new Point(216, 39);
            lbFlowerBouquetCategory.Name = "lbFlowerBouquetCategory";
            lbFlowerBouquetCategory.Size = new Size(72, 20);
            lbFlowerBouquetCategory.TabIndex = 2;
            lbFlowerBouquetCategory.Text = "Category:";
            // 
            // lbFlowerBouquetDescription
            // 
            lbFlowerBouquetDescription.AutoSize = true;
            lbFlowerBouquetDescription.Location = new Point(38, 134);
            lbFlowerBouquetDescription.Name = "lbFlowerBouquetDescription";
            lbFlowerBouquetDescription.Size = new Size(88, 20);
            lbFlowerBouquetDescription.TabIndex = 3;
            lbFlowerBouquetDescription.Text = "Description:";
            // 
            // lbFlowerBouquetUnitsInStock
            // 
            lbFlowerBouquetUnitsInStock.AllowDrop = true;
            lbFlowerBouquetUnitsInStock.AutoSize = true;
            lbFlowerBouquetUnitsInStock.Location = new Point(279, 249);
            lbFlowerBouquetUnitsInStock.Name = "lbFlowerBouquetUnitsInStock";
            lbFlowerBouquetUnitsInStock.Size = new Size(99, 20);
            lbFlowerBouquetUnitsInStock.TabIndex = 4;
            lbFlowerBouquetUnitsInStock.Text = "Units in stock:";
            // 
            // lbFlowerBouquetStatus
            // 
            lbFlowerBouquetStatus.AutoSize = true;
            lbFlowerBouquetStatus.Location = new Point(41, 294);
            lbFlowerBouquetStatus.Name = "lbFlowerBouquetStatus";
            lbFlowerBouquetStatus.Size = new Size(49, 20);
            lbFlowerBouquetStatus.TabIndex = 5;
            lbFlowerBouquetStatus.Text = "Status";
            // 
            // lbFlowerBouquetSupplierId
            // 
            lbFlowerBouquetSupplierId.AutoSize = true;
            lbFlowerBouquetSupplierId.Location = new Point(41, 341);
            lbFlowerBouquetSupplierId.Name = "lbFlowerBouquetSupplierId";
            lbFlowerBouquetSupplierId.Size = new Size(67, 20);
            lbFlowerBouquetSupplierId.TabIndex = 6;
            lbFlowerBouquetSupplierId.Text = "Supplier:";
            // 
            // lbFlowerBouquetUnitPrice
            // 
            lbFlowerBouquetUnitPrice.AutoSize = true;
            lbFlowerBouquetUnitPrice.Location = new Point(38, 249);
            lbFlowerBouquetUnitPrice.Name = "lbFlowerBouquetUnitPrice";
            lbFlowerBouquetUnitPrice.Size = new Size(76, 20);
            lbFlowerBouquetUnitPrice.TabIndex = 7;
            lbFlowerBouquetUnitPrice.Text = "Unit price:";
            // 
            // lbFlowerBouquetMorphology
            // 
            lbFlowerBouquetMorphology.AutoSize = true;
            lbFlowerBouquetMorphology.Location = new Point(41, 388);
            lbFlowerBouquetMorphology.Name = "lbFlowerBouquetMorphology";
            lbFlowerBouquetMorphology.Size = new Size(94, 20);
            lbFlowerBouquetMorphology.TabIndex = 8;
            lbFlowerBouquetMorphology.Text = "Morphology:";
            // 
            // txtFlowerBouquetId
            // 
            txtFlowerBouquetId.Enabled = false;
            txtFlowerBouquetId.Location = new Point(143, 36);
            txtFlowerBouquetId.Name = "txtFlowerBouquetId";
            txtFlowerBouquetId.Size = new Size(48, 27);
            txtFlowerBouquetId.TabIndex = 9;
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Enabled = false;
            txtFlowerBouquetName.Location = new Point(143, 81);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.Size = new Size(302, 27);
            txtFlowerBouquetName.TabIndex = 10;
            // 
            // txtFlowerBouquetCategory
            // 
            txtFlowerBouquetCategory.Enabled = false;
            txtFlowerBouquetCategory.Location = new Point(294, 36);
            txtFlowerBouquetCategory.Name = "txtFlowerBouquetCategory";
            txtFlowerBouquetCategory.Size = new Size(151, 27);
            txtFlowerBouquetCategory.TabIndex = 11;
            // 
            // txtFlowerBouquetUnitsInStock
            // 
            txtFlowerBouquetUnitsInStock.Enabled = false;
            txtFlowerBouquetUnitsInStock.Location = new Point(384, 246);
            txtFlowerBouquetUnitsInStock.Name = "txtFlowerBouquetUnitsInStock";
            txtFlowerBouquetUnitsInStock.Size = new Size(61, 27);
            txtFlowerBouquetUnitsInStock.TabIndex = 12;
            // 
            // rtxtFlowerBouquetDescription
            // 
            rtxtFlowerBouquetDescription.Enabled = false;
            rtxtFlowerBouquetDescription.Location = new Point(143, 134);
            rtxtFlowerBouquetDescription.Name = "rtxtFlowerBouquetDescription";
            rtxtFlowerBouquetDescription.Size = new Size(302, 90);
            rtxtFlowerBouquetDescription.TabIndex = 13;
            rtxtFlowerBouquetDescription.Text = "";
            // 
            // txtFlowerBouquetUnitPrice
            // 
            txtFlowerBouquetUnitPrice.Enabled = false;
            txtFlowerBouquetUnitPrice.Location = new Point(143, 242);
            txtFlowerBouquetUnitPrice.Name = "txtFlowerBouquetUnitPrice";
            txtFlowerBouquetUnitPrice.Size = new Size(109, 27);
            txtFlowerBouquetUnitPrice.TabIndex = 14;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Enabled = false;
            txtSupplierName.Location = new Point(143, 338);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(302, 27);
            txtSupplierName.TabIndex = 15;
            // 
            // txtFlowerBouquetStatus
            // 
            txtFlowerBouquetStatus.Enabled = false;
            txtFlowerBouquetStatus.Location = new Point(143, 291);
            txtFlowerBouquetStatus.Name = "txtFlowerBouquetStatus";
            txtFlowerBouquetStatus.Size = new Size(109, 27);
            txtFlowerBouquetStatus.TabIndex = 16;
            // 
            // txtFlowerBouquetMorphology
            // 
            txtFlowerBouquetMorphology.Enabled = false;
            txtFlowerBouquetMorphology.Location = new Point(143, 385);
            txtFlowerBouquetMorphology.Name = "txtFlowerBouquetMorphology";
            txtFlowerBouquetMorphology.Size = new Size(302, 27);
            txtFlowerBouquetMorphology.TabIndex = 17;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(473, 39);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(552, 432);
            dgvProductList.TabIndex = 18;
            dgvProductList.CellClick += dgvProductList_CellContentClick;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(194, 442);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(351, 442);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(41, 442);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(1055, 36);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 23;
            lbSearch.Text = "Search";
            // 
            // lbInPriceAmount
            // 
            lbInPriceAmount.AutoSize = true;
            lbInPriceAmount.Location = new Point(1056, 104);
            lbInPriceAmount.Name = "lbInPriceAmount";
            lbInPriceAmount.Size = new Size(41, 20);
            lbInPriceAmount.TabIndex = 24;
            lbInPriceAmount.Text = "Price";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(1055, 59);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(255, 27);
            txtSearchValue.TabIndex = 25;
            // 
            // txtLowerPrice
            // 
            txtLowerPrice.Location = new Point(1055, 134);
            txtLowerPrice.Name = "txtLowerPrice";
            txtLowerPrice.Size = new Size(120, 27);
            txtLowerPrice.TabIndex = 26;
            // 
            // txtUpperPrice
            // 
            txtUpperPrice.Location = new Point(1195, 134);
            txtUpperPrice.Name = "txtUpperPrice";
            txtUpperPrice.Size = new Size(115, 27);
            txtUpperPrice.TabIndex = 27;
            // 
            // lbConnect
            // 
            lbConnect.AutoSize = true;
            lbConnect.Location = new Point(1177, 138);
            lbConnect.Name = "lbConnect";
            lbConnect.Size = new Size(15, 20);
            lbConnect.TabIndex = 28;
            lbConnect.Text = "-";
            // 
            // cbxShowUnitInStock
            // 
            cbxShowUnitInStock.AutoSize = true;
            cbxShowUnitInStock.Location = new Point(1056, 242);
            cbxShowUnitInStock.Name = "cbxShowUnitInStock";
            cbxShowUnitInStock.Size = new Size(150, 24);
            cbxShowUnitInStock.TabIndex = 29;
            cbxShowUnitInStock.Text = "Show unit in stock";
            cbxShowUnitInStock.UseVisualStyleBackColor = true;
            cbxShowUnitInStock.CheckedChanged += cbxShowUnitInStock_CheckedChanged;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(1056, 186);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(254, 29);
            btSearch.TabIndex = 30;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // lbArrangeBy
            // 
            lbArrangeBy.AutoSize = true;
            lbArrangeBy.Location = new Point(1058, 367);
            lbArrangeBy.Name = "lbArrangeBy";
            lbArrangeBy.Size = new Size(85, 20);
            lbArrangeBy.TabIndex = 33;
            lbArrangeBy.Text = "Arrange by:";
            // 
            // btnArrangeDecline
            // 
            btnArrangeDecline.Location = new Point(1055, 442);
            btnArrangeDecline.Name = "btnArrangeDecline";
            btnArrangeDecline.Size = new Size(94, 29);
            btnArrangeDecline.TabIndex = 31;
            btnArrangeDecline.Text = "Z-A";
            btnArrangeDecline.UseVisualStyleBackColor = true;
            btnArrangeDecline.Click += btnArrangeDecline_Click;
            // 
            // btnArrangeIncrease
            // 
            btnArrangeIncrease.Location = new Point(1055, 407);
            btnArrangeIncrease.Name = "btnArrangeIncrease";
            btnArrangeIncrease.Size = new Size(94, 29);
            btnArrangeIncrease.TabIndex = 32;
            btnArrangeIncrease.Text = "A-Z";
            btnArrangeIncrease.UseVisualStyleBackColor = true;
            btnArrangeIncrease.Click += btnArrangeIncrease_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1240, 497);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 530);
            Controls.Add(btnBack);
            Controls.Add(lbArrangeBy);
            Controls.Add(btnArrangeIncrease);
            Controls.Add(btnArrangeDecline);
            Controls.Add(btSearch);
            Controls.Add(cbxShowUnitInStock);
            Controls.Add(lbConnect);
            Controls.Add(txtUpperPrice);
            Controls.Add(txtLowerPrice);
            Controls.Add(txtSearchValue);
            Controls.Add(lbInPriceAmount);
            Controls.Add(lbSearch);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvProductList);
            Controls.Add(txtFlowerBouquetMorphology);
            Controls.Add(txtFlowerBouquetStatus);
            Controls.Add(txtSupplierName);
            Controls.Add(txtFlowerBouquetUnitPrice);
            Controls.Add(rtxtFlowerBouquetDescription);
            Controls.Add(txtFlowerBouquetUnitsInStock);
            Controls.Add(txtFlowerBouquetCategory);
            Controls.Add(txtFlowerBouquetName);
            Controls.Add(txtFlowerBouquetId);
            Controls.Add(lbFlowerBouquetMorphology);
            Controls.Add(lbFlowerBouquetUnitPrice);
            Controls.Add(lbFlowerBouquetSupplierId);
            Controls.Add(lbFlowerBouquetStatus);
            Controls.Add(lbFlowerBouquetUnitsInStock);
            Controls.Add(lbFlowerBouquetDescription);
            Controls.Add(lbFlowerBouquetCategory);
            Controls.Add(lbFlowerBouquetName);
            Controls.Add(lbFlowerBouquetId);
            Name = "frmProductManagement";
            Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFlowerBouquetId;
        private Label lbFlowerBouquetName;
        private Label lbFlowerBouquetCategory;
        private Label lbFlowerBouquetDescription;
        private Label lbFlowerBouquetUnitsInStock;
        private Label lbFlowerBouquetStatus;
        private Label lbFlowerBouquetSupplierId;
        private Label lbFlowerBouquetUnitPrice;
        private Label lbFlowerBouquetMorphology;
        private TextBox txtFlowerBouquetId;
        private TextBox txtFlowerBouquetName;
        private TextBox txtFlowerBouquetCategory;
        private TextBox txtFlowerBouquetUnitsInStock;
        private RichTextBox rtxtFlowerBouquetDescription;
        private TextBox txtFlowerBouquetUnitPrice;
        private TextBox txtSupplierName;
        private TextBox txtFlowerBouquetStatus;
        private TextBox txtFlowerBouquetMorphology;
        private DataGridView dgvProductList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Label lbSearch;
        private Label lbInPriceAmount;
        private TextBox txtSearchValue;
        private TextBox txtLowerPrice;
        private TextBox txtUpperPrice;
        private Label lbConnect;
        private CheckBox cbxShowUnitInStock;
        private Button btSearch;
        private Label lbArrangeBy;
        private Button btnArrangeDecline;
        private Button btnArrangeIncrease;
        private Button btnBack;
    }
}