namespace SaleManagementWinApp
{
    partial class frmOrders
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
            dgvOrderList = new DataGridView();
            lbOrderId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbOrderList = new Label();
            txtOrderId = new TextBox();
            txtCustomerId = new TextBox();
            txtOrderTotal = new TextBox();
            txtOrderStatus = new TextBox();
            dtpOrderDate = new DateTimePicker();
            dtpShippingDate = new DateTimePicker();
            btCreate = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            btBack = new Button();
            dgvOrderDetailsOfOrder = new DataGridView();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailsOfOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(550, 46);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(345, 399);
            dgvOrderList.TabIndex = 0;
            dgvOrderList.CellClick += dgvOrderList_CellContentClick;
            dgvOrderList.CellContentClick += dgvOrderList_CellContentClick;
            // 
            // lbOrderId
            // 
            lbOrderId.AutoSize = true;
            lbOrderId.Location = new Point(57, 111);
            lbOrderId.Name = "lbOrderId";
            lbOrderId.Size = new Size(67, 20);
            lbOrderId.TabIndex = 1;
            lbOrderId.Text = "Order id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 169);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 224);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Order date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 282);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 4;
            label4.Text = "Shipping date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 340);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 5;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 340);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Status";
            // 
            // lbOrderList
            // 
            lbOrderList.AutoSize = true;
            lbOrderList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbOrderList.Location = new Point(12, 46);
            lbOrderList.Name = "lbOrderList";
            lbOrderList.Size = new Size(140, 41);
            lbOrderList.TabIndex = 7;
            lbOrderList.Text = "Order list";
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Location = new Point(184, 111);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(304, 27);
            txtOrderId.TabIndex = 8;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(184, 166);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(304, 27);
            txtCustomerId.TabIndex = 9;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(184, 337);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(137, 27);
            txtOrderTotal.TabIndex = 10;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Enabled = false;
            txtOrderStatus.Location = new Point(424, 337);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new Size(64, 27);
            txtOrderStatus.TabIndex = 11;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Location = new Point(184, 219);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(304, 27);
            dtpOrderDate.TabIndex = 12;
            // 
            // dtpShippingDate
            // 
            dtpShippingDate.Enabled = false;
            dtpShippingDate.Location = new Point(184, 277);
            dtpShippingDate.Name = "dtpShippingDate";
            dtpShippingDate.Size = new Size(304, 27);
            dtpShippingDate.TabIndex = 13;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(57, 416);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 29);
            btCreate.TabIndex = 14;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(170, 416);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 16;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(394, 416);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 17;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(1135, 471);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 18;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // dgvOrderDetailsOfOrder
            // 
            dgvOrderDetailsOfOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailsOfOrder.Location = new Point(901, 46);
            dgvOrderDetailsOfOrder.Name = "dgvOrderDetailsOfOrder";
            dgvOrderDetailsOfOrder.RowHeadersWidth = 51;
            dgvOrderDetailsOfOrder.RowTemplate.Height = 29;
            dgvOrderDetailsOfOrder.Size = new Size(328, 399);
            dgvOrderDetailsOfOrder.TabIndex = 19;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(285, 416);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 512);
            Controls.Add(btnRefresh);
            Controls.Add(dgvOrderDetailsOfOrder);
            Controls.Add(btBack);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btCreate);
            Controls.Add(dtpShippingDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtOrderTotal);
            Controls.Add(txtCustomerId);
            Controls.Add(txtOrderId);
            Controls.Add(lbOrderList);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOrderId);
            Controls.Add(dgvOrderList);
            Name = "frmOrders";
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailsOfOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderList;
        private Label lbOrderId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbOrderList;
        private TextBox txtOrderId;
        private TextBox txtCustomerId;
        private TextBox txtOrderTotal;
        private TextBox txtOrderStatus;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpShippingDate;
        private Button btCreate;
        private Button btUpdate;
        private Button btDelete;
        private Button btBack;
        private DataGridView dgvOrderDetailsOfOrder;
        private Button btnRefresh;
    }
}