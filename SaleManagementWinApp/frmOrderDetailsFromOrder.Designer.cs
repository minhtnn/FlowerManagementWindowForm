namespace SaleManagementWinApp
{
    partial class frmOrderDetailsFromOrder
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
            dvgOrderDetailsListFromOrder = new DataGridView();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgOrderDetailsListFromOrder).BeginInit();
            SuspendLayout();
            // 
            // dvgOrderDetailsListFromOrder
            // 
            dvgOrderDetailsListFromOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgOrderDetailsListFromOrder.Location = new Point(33, 41);
            dvgOrderDetailsListFromOrder.Name = "dvgOrderDetailsListFromOrder";
            dvgOrderDetailsListFromOrder.RowHeadersWidth = 51;
            dvgOrderDetailsListFromOrder.RowTemplate.Height = 29;
            dvgOrderDetailsListFromOrder.Size = new Size(796, 330);
            dvgOrderDetailsListFromOrder.TabIndex = 0;
            dvgOrderDetailsListFromOrder.CellContentClick += dvgOrderDetailsListFromOrder_CellContentClick;
            // 
            // btBack
            // 
            btBack.Location = new Point(759, 390);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 1;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // frmOrderDetailsFromOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 431);
            Controls.Add(btBack);
            Controls.Add(dvgOrderDetailsListFromOrder);
            Name = "frmOrderDetailsFromOrder";
            Text = "Order details";
            ((System.ComponentModel.ISupportInitialize)dvgOrderDetailsListFromOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgOrderDetailsListFromOrder;
        private Button btBack;
    }
}