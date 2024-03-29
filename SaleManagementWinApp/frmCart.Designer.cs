namespace SaleManagementWinApp
{
    partial class frmCart
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
            btnCreateOrder = new Button();
            btRemove = new Button();
            dtpOrderDate = new DateTimePicker();
            txtOrderStatus = new TextBox();
            txtCustomerId = new TextBox();
            txtOrderId = new TextBox();
            lbOrderStatus = new Label();
            lbOrderDate = new Label();
            lbCustomerId = new Label();
            lbOrderId = new Label();
            lbTotalValue = new Label();
            lbTotalTitle = new Label();
            dgvCart = new DataGridView();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(144, 312);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(120, 29);
            btnCreateOrder.TabIndex = 25;
            btnCreateOrder.Text = "Create order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(277, 312);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(117, 29);
            btRemove.TabIndex = 24;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(144, 158);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 22;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Enabled = false;
            txtOrderStatus.Location = new Point(144, 217);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.ReadOnly = true;
            txtOrderStatus.Size = new Size(250, 27);
            txtOrderStatus.TabIndex = 21;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(144, 102);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(250, 27);
            txtCustomerId.TabIndex = 20;
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Location = new Point(144, 48);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(250, 27);
            txtOrderId.TabIndex = 19;
            // 
            // lbOrderStatus
            // 
            lbOrderStatus.AutoSize = true;
            lbOrderStatus.Location = new Point(30, 220);
            lbOrderStatus.Name = "lbOrderStatus";
            lbOrderStatus.Size = new Size(52, 20);
            lbOrderStatus.TabIndex = 18;
            lbOrderStatus.Text = "Status:";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(30, 163);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(84, 20);
            lbOrderDate.TabIndex = 17;
            lbOrderDate.Text = "Order date:";
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(30, 105);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(92, 20);
            lbCustomerId.TabIndex = 16;
            lbCustomerId.Text = "Customer id:";
            // 
            // lbOrderId
            // 
            lbOrderId.AutoSize = true;
            lbOrderId.Location = new Point(30, 51);
            lbOrderId.Name = "lbOrderId";
            lbOrderId.Size = new Size(67, 20);
            lbOrderId.TabIndex = 15;
            lbOrderId.Text = "Order id:";
            // 
            // lbTotalValue
            // 
            lbTotalValue.AutoSize = true;
            lbTotalValue.Location = new Point(144, 270);
            lbTotalValue.Name = "lbTotalValue";
            lbTotalValue.Size = new Size(0, 20);
            lbTotalValue.TabIndex = 27;
            // 
            // lbTotalTitle
            // 
            lbTotalTitle.AutoSize = true;
            lbTotalTitle.Location = new Point(30, 270);
            lbTotalTitle.Name = "lbTotalTitle";
            lbTotalTitle.Size = new Size(45, 20);
            lbTotalTitle.TabIndex = 26;
            lbTotalTitle.Text = "Total:";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(416, 48);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(387, 314);
            dgvCart.TabIndex = 28;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // btBack
            // 
            btBack.Location = new Point(144, 347);
            btBack.Name = "btBack";
            btBack.Size = new Size(250, 29);
            btBack.TabIndex = 29;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 385);
            Controls.Add(btBack);
            Controls.Add(dgvCart);
            Controls.Add(lbTotalValue);
            Controls.Add(lbTotalTitle);
            Controls.Add(btnCreateOrder);
            Controls.Add(btRemove);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtCustomerId);
            Controls.Add(txtOrderId);
            Controls.Add(lbOrderStatus);
            Controls.Add(lbOrderDate);
            Controls.Add(lbCustomerId);
            Controls.Add(lbOrderId);
            Name = "frmCart";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateOrder;
        private Button btRemove;
        private DateTimePicker dtpOrderDate;
        private TextBox txtOrderStatus;
        private TextBox txtCustomerId;
        private TextBox txtOrderId;
        private Label lbOrderStatus;
        private Label lbOrderDate;
        private Label lbCustomerId;
        private Label lbOrderId;
        private Label lbTotalValue;
        private Label lbTotalTitle;
        private DataGridView dgvCart;
        private Button btBack;
    }
}