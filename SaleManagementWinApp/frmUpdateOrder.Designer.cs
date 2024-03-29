namespace SaleManagementWinApp
{
    partial class frmUpdateOrder
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
            dtpShippingDate = new DateTimePicker();
            dtpOrderDate = new DateTimePicker();
            txtOrderStatus = new TextBox();
            txtOrderTotal = new TextBox();
            txtCustomerId = new TextBox();
            txtOrderId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbOrderId = new Label();
            btUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // dtpShippingDate
            // 
            dtpShippingDate.Location = new Point(165, 232);
            dtpShippingDate.Name = "dtpShippingDate";
            dtpShippingDate.Size = new Size(304, 27);
            dtpShippingDate.TabIndex = 25;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(165, 174);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(304, 27);
            dtpOrderDate.TabIndex = 24;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new Point(405, 292);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new Size(64, 27);
            txtOrderStatus.TabIndex = 23;
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(165, 292);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(137, 27);
            txtOrderTotal.TabIndex = 22;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(165, 121);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(304, 27);
            txtCustomerId.TabIndex = 21;
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Location = new Point(165, 66);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(304, 27);
            txtOrderId.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 295);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 19;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 295);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 18;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 237);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 17;
            label4.Text = "Shipping date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 179);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 16;
            label3.Text = "Order date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 15;
            label2.Text = "Customer id:";
            // 
            // lbOrderId
            // 
            lbOrderId.AutoSize = true;
            lbOrderId.Location = new Point(38, 66);
            lbOrderId.Name = "lbOrderId";
            lbOrderId.Size = new Size(67, 20);
            lbOrderId.TabIndex = 14;
            lbOrderId.Text = "Order id:";
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(257, 349);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 26;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(377, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmUpdateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 405);
            Controls.Add(btnCancel);
            Controls.Add(btUpdate);
            Controls.Add(dtpShippingDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtOrderTotal);
            Controls.Add(txtCustomerId);
            Controls.Add(txtOrderId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbOrderId);
            Name = "frmUpdateOrder";
            Text = "frmUpdateOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpShippingDate;
        private DateTimePicker dtpOrderDate;
        private TextBox txtOrderStatus;
        private TextBox txtOrderTotal;
        private TextBox txtCustomerId;
        private TextBox txtOrderId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbOrderId;
        private Button btUpdate;
        private Button btnCancel;
    }
}