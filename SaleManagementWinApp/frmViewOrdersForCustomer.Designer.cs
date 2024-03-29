
namespace SaleManagementWinApp
{
    partial class frmViewOrdersForCustomer
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
            grbOrderHistory = new GroupBox();
            btViewOrderDetail = new Button();
            dtpShippingDate = new DateTimePicker();
            dtpOrderDate = new DateTimePicker();
            txtOrderTotal = new TextBox();
            txtOrderId = new TextBox();
            dgvOrderList = new DataGridView();
            lbOrderTotal = new Label();
            lbShippingDate = new Label();
            lbOrderDate = new Label();
            lbOrderId = new Label();
            btBack = new Button();
            grbOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // grbOrderHistory
            // 
            grbOrderHistory.Controls.Add(btViewOrderDetail);
            grbOrderHistory.Controls.Add(dtpShippingDate);
            grbOrderHistory.Controls.Add(dtpOrderDate);
            grbOrderHistory.Controls.Add(txtOrderTotal);
            grbOrderHistory.Controls.Add(txtOrderId);
            grbOrderHistory.Controls.Add(dgvOrderList);
            grbOrderHistory.Controls.Add(lbOrderTotal);
            grbOrderHistory.Controls.Add(lbShippingDate);
            grbOrderHistory.Controls.Add(lbOrderDate);
            grbOrderHistory.Controls.Add(lbOrderId);
            grbOrderHistory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            grbOrderHistory.Location = new Point(25, 26);
            grbOrderHistory.Name = "grbOrderHistory";
            grbOrderHistory.Size = new Size(885, 363);
            grbOrderHistory.TabIndex = 0;
            grbOrderHistory.TabStop = false;
            grbOrderHistory.Text = "Order History";
            // 
            // btViewOrderDetail
            // 
            btViewOrderDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btViewOrderDetail.Location = new Point(187, 314);
            btViewOrderDetail.Name = "btViewOrderDetail";
            btViewOrderDetail.Size = new Size(150, 29);
            btViewOrderDetail.TabIndex = 10;
            btViewOrderDetail.Text = "View order detail";
            btViewOrderDetail.UseVisualStyleBackColor = true;
            btViewOrderDetail.Click += btViewOrderDetail_Click;
            // 
            // dtpShippingDate
            // 
            dtpShippingDate.Enabled = false;
            dtpShippingDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpShippingDate.Location = new Point(151, 197);
            dtpShippingDate.Name = "dtpShippingDate";
            dtpShippingDate.Size = new Size(250, 27);
            dtpShippingDate.TabIndex = 8;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpOrderDate.Location = new Point(151, 132);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 7;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderTotal.Location = new Point(151, 257);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(250, 27);
            txtOrderTotal.TabIndex = 6;
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderId.Location = new Point(151, 74);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(250, 27);
            txtOrderId.TabIndex = 5;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeight = 18;
            dgvOrderList.Location = new Point(453, 28);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(426, 329);
            dgvOrderList.TabIndex = 4;
            dgvOrderList.CellClick += dgvOrderList_CellContentClick;
            dgvOrderList.CellContentClick += dgvOrderList_CellContentClick;
            // 
            // lbOrderTotal
            // 
            lbOrderTotal.AutoSize = true;
            lbOrderTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderTotal.Location = new Point(16, 260);
            lbOrderTotal.Name = "lbOrderTotal";
            lbOrderTotal.Size = new Size(45, 20);
            lbOrderTotal.TabIndex = 3;
            lbOrderTotal.Text = "Total:";
            // 
            // lbShippingDate
            // 
            lbShippingDate.AutoSize = true;
            lbShippingDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbShippingDate.Location = new Point(16, 197);
            lbShippingDate.Name = "lbShippingDate";
            lbShippingDate.Size = new Size(105, 20);
            lbShippingDate.TabIndex = 2;
            lbShippingDate.Text = "Shipping date:";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderDate.Location = new Point(16, 137);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(84, 20);
            lbOrderDate.TabIndex = 1;
            lbOrderDate.Text = "Order date:";
            // 
            // lbOrderId
            // 
            lbOrderId.AutoSize = true;
            lbOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderId.Location = new Point(16, 77);
            lbOrderId.Name = "lbOrderId";
            lbOrderId.Size = new Size(67, 20);
            lbOrderId.TabIndex = 0;
            lbOrderId.Text = "Order id:";
            // 
            // btBack
            // 
            btBack.Location = new Point(816, 409);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 0;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // frmViewOrdersForCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(btBack);
            Controls.Add(grbOrderHistory);
            Name = "frmViewOrdersForCustomer";
            Text = "Order History";
            grbOrderHistory.ResumeLayout(false);
            grbOrderHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbOrderHistory;
        private Button btBack;
        private DateTimePicker dtpShippingDate;
        private DateTimePicker dtpOrderDate;
        private TextBox txtOrderTotal;
        private TextBox txtOrderId;
        private DataGridView dgvOrderList;
        private Label lbOrderTotal;
        private Label lbShippingDate;
        private Label lbOrderDate;
        private Label lbOrderId;
        private Button btViewOrderDetail;
    }
}