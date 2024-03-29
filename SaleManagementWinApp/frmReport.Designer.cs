namespace SaleManagementWinApp
{
    partial class frmReport
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
            label1 = new Label();
            label2 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblTotalRevenue = new Label();
            lblTotalSoldProduct = new Label();
            lblTotalCustomer = new Label();
            txtTotalRevenue = new TextBox();
            txtTotalSoldProduct = new TextBox();
            txtTotalCustomers = new TextBox();
            lblTotalOrders = new Label();
            txtTotalOrders = new TextBox();
            dgvOrderDetailsList = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailsList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Start date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "End date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(110, 29);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 2;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(110, 76);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 3;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(27, 188);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(101, 20);
            lblTotalRevenue.TabIndex = 4;
            lblTotalRevenue.Text = "Total revenue:";
            // 
            // lblTotalSoldProduct
            // 
            lblTotalSoldProduct.AutoSize = true;
            lblTotalSoldProduct.Location = new Point(27, 246);
            lblTotalSoldProduct.Name = "lblTotalSoldProduct";
            lblTotalSoldProduct.Size = new Size(133, 20);
            lblTotalSoldProduct.TabIndex = 5;
            lblTotalSoldProduct.Text = "Total sold product:";
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.AutoSize = true;
            lblTotalCustomer.Location = new Point(27, 374);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(157, 20);
            lblTotalCustomer.TabIndex = 7;
            lblTotalCustomer.Text = "Quantity of customers:";
            // 
            // txtTotalRevenue
            // 
            txtTotalRevenue.Enabled = false;
            txtTotalRevenue.Location = new Point(235, 185);
            txtTotalRevenue.Name = "txtTotalRevenue";
            txtTotalRevenue.Size = new Size(125, 27);
            txtTotalRevenue.TabIndex = 8;
            // 
            // txtTotalSoldProduct
            // 
            txtTotalSoldProduct.Enabled = false;
            txtTotalSoldProduct.Location = new Point(235, 243);
            txtTotalSoldProduct.Name = "txtTotalSoldProduct";
            txtTotalSoldProduct.Size = new Size(125, 27);
            txtTotalSoldProduct.TabIndex = 9;
            // 
            // txtTotalCustomers
            // 
            txtTotalCustomers.Enabled = false;
            txtTotalCustomers.Location = new Point(235, 371);
            txtTotalCustomers.Name = "txtTotalCustomers";
            txtTotalCustomers.Size = new Size(125, 27);
            txtTotalCustomers.TabIndex = 11;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Location = new Point(28, 312);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(132, 20);
            lblTotalOrders.TabIndex = 12;
            lblTotalOrders.Text = "Quantity of orders:";
            // 
            // txtTotalOrders
            // 
            txtTotalOrders.Enabled = false;
            txtTotalOrders.Location = new Point(235, 309);
            txtTotalOrders.Name = "txtTotalOrders";
            txtTotalOrders.Size = new Size(125, 27);
            txtTotalOrders.TabIndex = 13;
            // 
            // dgvOrderDetailsList
            // 
            dgvOrderDetailsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailsList.Location = new Point(396, 29);
            dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            dgvOrderDetailsList.RowHeadersWidth = 51;
            dgvOrderDetailsList.RowTemplate.Height = 29;
            dgvOrderDetailsList.Size = new Size(691, 369);
            dgvOrderDetailsList.TabIndex = 14;
            dgvOrderDetailsList.CellContentClick += dgvOrderDetailsList_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(993, 417);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 458);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderDetailsList);
            Controls.Add(txtTotalOrders);
            Controls.Add(lblTotalOrders);
            Controls.Add(txtTotalCustomers);
            Controls.Add(txtTotalSoldProduct);
            Controls.Add(txtTotalRevenue);
            Controls.Add(lblTotalCustomer);
            Controls.Add(lblTotalSoldProduct);
            Controls.Add(lblTotalRevenue);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmReport";
            Text = "Report";
            Load += frmReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblTotalRevenue;
        private Label lblTotalSoldProduct;
        private Label lblTotalCustomer;
        private TextBox txtTotalRevenue;
        private TextBox txtTotalSoldProduct;
        private TextBox txtTotalCustomers;
        private Label lblTotalOrders;
        private TextBox txtTotalOrders;
        private DataGridView dgvOrderDetailsList;
        private Button btnBack;
    }
}