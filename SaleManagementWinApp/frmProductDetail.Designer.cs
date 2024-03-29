namespace SaleManagementWinApp
{
    partial class frmProductDetail
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtFlowerBouquetId = new TextBox();
            txtFlowerBouquetName = new TextBox();
            txtFlowerBouquetDescription = new RichTextBox();
            txtFlowerBouquetMorphology = new RichTextBox();
            txtFlowerBouquetUnitsInStock = new TextBox();
            txtFlowerBouquetUnitPrice = new TextBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            txtFlowerBouquetStatus = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 70);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "FlowerBouquet id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 130);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 191);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 130);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 70);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Unit price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 188);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 5;
            label6.Text = "Morphology";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(834, 70);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 6;
            label7.Text = "Units in stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(834, 133);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 7;
            label8.Text = "Supplier:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(834, 189);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 8;
            label9.Text = "Status:";
            // 
            // txtFlowerBouquetId
            // 
            txtFlowerBouquetId.Enabled = false;
            txtFlowerBouquetId.Location = new Point(192, 67);
            txtFlowerBouquetId.Name = "txtFlowerBouquetId";
            txtFlowerBouquetId.Size = new Size(183, 27);
            txtFlowerBouquetId.TabIndex = 9;
            // 
            // txtFlowerBouquetName
            // 
            txtFlowerBouquetName.Location = new Point(192, 127);
            txtFlowerBouquetName.Name = "txtFlowerBouquetName";
            txtFlowerBouquetName.Size = new Size(183, 27);
            txtFlowerBouquetName.TabIndex = 10;
            // 
            // txtFlowerBouquetDescription
            // 
            txtFlowerBouquetDescription.Location = new Point(192, 188);
            txtFlowerBouquetDescription.Name = "txtFlowerBouquetDescription";
            txtFlowerBouquetDescription.Size = new Size(183, 82);
            txtFlowerBouquetDescription.TabIndex = 11;
            txtFlowerBouquetDescription.Text = "";
            // 
            // txtFlowerBouquetMorphology
            // 
            txtFlowerBouquetMorphology.Location = new Point(564, 191);
            txtFlowerBouquetMorphology.Name = "txtFlowerBouquetMorphology";
            txtFlowerBouquetMorphology.Size = new Size(199, 79);
            txtFlowerBouquetMorphology.TabIndex = 12;
            txtFlowerBouquetMorphology.Text = "";
            // 
            // txtFlowerBouquetUnitsInStock
            // 
            txtFlowerBouquetUnitsInStock.Location = new Point(947, 70);
            txtFlowerBouquetUnitsInStock.Name = "txtFlowerBouquetUnitsInStock";
            txtFlowerBouquetUnitsInStock.Size = new Size(199, 27);
            txtFlowerBouquetUnitsInStock.TabIndex = 13;
            // 
            // txtFlowerBouquetUnitPrice
            // 
            txtFlowerBouquetUnitPrice.Location = new Point(564, 67);
            txtFlowerBouquetUnitPrice.Name = "txtFlowerBouquetUnitPrice";
            txtFlowerBouquetUnitPrice.Size = new Size(199, 27);
            txtFlowerBouquetUnitPrice.TabIndex = 14;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(564, 127);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(199, 28);
            cmbCategory.TabIndex = 15;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(947, 133);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(199, 28);
            cmbSupplier.TabIndex = 16;
            // 
            // txtFlowerBouquetStatus
            // 
            txtFlowerBouquetStatus.Location = new Point(947, 188);
            txtFlowerBouquetStatus.Name = "txtFlowerBouquetStatus";
            txtFlowerBouquetStatus.Size = new Size(199, 27);
            txtFlowerBouquetStatus.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(924, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1052, 308);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtFlowerBouquetStatus);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(txtFlowerBouquetUnitPrice);
            Controls.Add(txtFlowerBouquetUnitsInStock);
            Controls.Add(txtFlowerBouquetMorphology);
            Controls.Add(txtFlowerBouquetDescription);
            Controls.Add(txtFlowerBouquetName);
            Controls.Add(txtFlowerBouquetId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductDetail";
            Text = "Product detail";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtFlowerBouquetId;
        private TextBox txtFlowerBouquetName;
        private RichTextBox txtFlowerBouquetDescription;
        private RichTextBox txtFlowerBouquetMorphology;
        private TextBox txtFlowerBouquetUnitsInStock;
        private TextBox txtFlowerBouquetUnitPrice;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private TextBox txtFlowerBouquetStatus;
        private Button btnUpdate;
        private Button btnCancel;
    }
}