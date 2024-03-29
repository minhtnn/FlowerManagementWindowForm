namespace SaleManagementWinApp
{
    partial class frmCreateOrder
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
            btAdd = new Button();
            dgvProductList = new DataGridView();
            btnCancel = new Button();
            txtSearchProduct = new TextBox();
            btSearchProduct = new Button();
            btnGoToCart = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Location = new Point(29, 333);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(114, 29);
            btAdd.TabIndex = 10;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(29, 39);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(843, 284);
            dgvProductList.TabIndex = 12;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(778, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(583, 335);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(177, 27);
            txtSearchProduct.TabIndex = 15;
            // 
            // btSearchProduct
            // 
            btSearchProduct.Location = new Point(778, 334);
            btSearchProduct.Name = "btSearchProduct";
            btSearchProduct.Size = new Size(94, 29);
            btSearchProduct.TabIndex = 16;
            btSearchProduct.Text = "Search";
            btSearchProduct.UseVisualStyleBackColor = true;
            btSearchProduct.Click += btSearchProduct_Click;
            // 
            // btnGoToCart
            // 
            btnGoToCart.Location = new Point(149, 333);
            btnGoToCart.Name = "btnGoToCart";
            btnGoToCart.Size = new Size(115, 29);
            btnGoToCart.TabIndex = 14;
            btnGoToCart.Text = "Go to cart";
            btnGoToCart.UseVisualStyleBackColor = true;
            btnGoToCart.Click += btnCreateOrder_Click;
            // 
            // frmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 414);
            Controls.Add(btSearchProduct);
            Controls.Add(txtSearchProduct);
            Controls.Add(btnGoToCart);
            Controls.Add(btnCancel);
            Controls.Add(dgvProductList);
            Controls.Add(btAdd);
            Name = "frmCreateOrder";
            Text = "Create order";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btAdd;
        private DataGridView dgvProductList;
        private Button btnCancel;
        private Button btnGoToCart;
        private TextBox txtSearchProduct;
        private Button btSearchProduct;
        private DataGridView dgvCart;
    }
}