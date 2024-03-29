namespace SaleManagementWinApp
{
    partial class frmCustomerManagement
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
            dgvCustomerList = new DataGridView();
            lbCustomerId = new Label();
            lbCustomerName = new Label();
            lbCustomerEmail = new Label();
            lbCustomerPassword = new Label();
            lbCustomerCity = new Label();
            lbCustomerCountry = new Label();
            lbCustomerBirthday = new Label();
            lbCustomerList = new Label();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerPassword = new TextBox();
            txtCustomerCity = new TextBox();
            txtCustomerCountry = new TextBox();
            dtcCustomerBirthday = new DateTimePicker();
            btCreate = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            btBack = new Button();
            lbStatus = new Label();
            txtCustomerStatus = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(569, 43);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.RowTemplate.Height = 29;
            dgvCustomerList.Size = new Size(427, 436);
            dgvCustomerList.TabIndex = 0;
            dgvCustomerList.CellClick += dgvCustomerList_CellContentClick;
            dgvCustomerList.CellContentClick += dgvCustomerList_CellContentClick;
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(54, 115);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(92, 20);
            lbCustomerId.TabIndex = 1;
            lbCustomerId.Text = "Customer id:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(54, 170);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 20);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Customer name:";
            // 
            // lbCustomerEmail
            // 
            lbCustomerEmail.AutoSize = true;
            lbCustomerEmail.Location = new Point(54, 225);
            lbCustomerEmail.Name = "lbCustomerEmail";
            lbCustomerEmail.Size = new Size(49, 20);
            lbCustomerEmail.TabIndex = 3;
            lbCustomerEmail.Text = "Email:";
            // 
            // lbCustomerPassword
            // 
            lbCustomerPassword.AutoSize = true;
            lbCustomerPassword.Location = new Point(54, 281);
            lbCustomerPassword.Name = "lbCustomerPassword";
            lbCustomerPassword.Size = new Size(73, 20);
            lbCustomerPassword.TabIndex = 4;
            lbCustomerPassword.Text = "Password:";
            // 
            // lbCustomerCity
            // 
            lbCustomerCity.AutoSize = true;
            lbCustomerCity.Location = new Point(54, 337);
            lbCustomerCity.Name = "lbCustomerCity";
            lbCustomerCity.Size = new Size(37, 20);
            lbCustomerCity.TabIndex = 5;
            lbCustomerCity.Text = "City:";
            // 
            // lbCustomerCountry
            // 
            lbCustomerCountry.AutoSize = true;
            lbCustomerCountry.Location = new Point(330, 337);
            lbCustomerCountry.Name = "lbCustomerCountry";
            lbCustomerCountry.Size = new Size(63, 20);
            lbCustomerCountry.TabIndex = 6;
            lbCustomerCountry.Text = "Country:";
            // 
            // lbCustomerBirthday
            // 
            lbCustomerBirthday.AutoSize = true;
            lbCustomerBirthday.Location = new Point(54, 388);
            lbCustomerBirthday.Name = "lbCustomerBirthday";
            lbCustomerBirthday.Size = new Size(67, 20);
            lbCustomerBirthday.TabIndex = 7;
            lbCustomerBirthday.Text = "Birthday:";
            // 
            // lbCustomerList
            // 
            lbCustomerList.AutoSize = true;
            lbCustomerList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbCustomerList.Location = new Point(32, 43);
            lbCustomerList.Name = "lbCustomerList";
            lbCustomerList.Size = new Size(199, 41);
            lbCustomerList.TabIndex = 8;
            lbCustomerList.Text = "Customer list:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(174, 115);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(331, 27);
            txtCustomerId.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Enabled = false;
            txtCustomerName.Location = new Point(174, 167);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(331, 27);
            txtCustomerName.TabIndex = 10;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Enabled = false;
            txtCustomerEmail.Location = new Point(174, 222);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(331, 27);
            txtCustomerEmail.TabIndex = 11;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Enabled = false;
            txtCustomerPassword.Location = new Point(174, 278);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(111, 27);
            txtCustomerPassword.TabIndex = 12;
            // 
            // txtCustomerCity
            // 
            txtCustomerCity.Enabled = false;
            txtCustomerCity.Location = new Point(174, 334);
            txtCustomerCity.Name = "txtCustomerCity";
            txtCustomerCity.Size = new Size(111, 27);
            txtCustomerCity.TabIndex = 13;
            // 
            // txtCustomerCountry
            // 
            txtCustomerCountry.Enabled = false;
            txtCustomerCountry.Location = new Point(399, 334);
            txtCustomerCountry.Name = "txtCustomerCountry";
            txtCustomerCountry.Size = new Size(106, 27);
            txtCustomerCountry.TabIndex = 14;
            // 
            // dtcCustomerBirthday
            // 
            dtcCustomerBirthday.Enabled = false;
            dtcCustomerBirthday.Location = new Point(174, 388);
            dtcCustomerBirthday.Name = "dtcCustomerBirthday";
            dtcCustomerBirthday.Size = new Size(331, 27);
            dtcCustomerBirthday.TabIndex = 15;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(54, 450);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 29);
            btCreate.TabIndex = 16;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(228, 450);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 17;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(411, 450);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 18;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(902, 497);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 19;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(330, 281);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 20;
            lbStatus.Text = "Status";
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Enabled = false;
            txtCustomerStatus.Location = new Point(399, 278);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.Size = new Size(106, 27);
            txtCustomerStatus.TabIndex = 21;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 534);
            Controls.Add(txtCustomerStatus);
            Controls.Add(lbStatus);
            Controls.Add(btBack);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btCreate);
            Controls.Add(dtcCustomerBirthday);
            Controls.Add(txtCustomerCountry);
            Controls.Add(txtCustomerCity);
            Controls.Add(txtCustomerPassword);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lbCustomerList);
            Controls.Add(lbCustomerBirthday);
            Controls.Add(lbCustomerCountry);
            Controls.Add(lbCustomerCity);
            Controls.Add(lbCustomerPassword);
            Controls.Add(lbCustomerEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCustomerId);
            Controls.Add(dgvCustomerList);
            Name = "frmCustomerManagement";
            Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerList;
        private Label lbCustomerId;
        private Label lbCustomerName;
        private Label lbCustomerEmail;
        private Label lbCustomerPassword;
        private Label lbCustomerCity;
        private Label lbCustomerCountry;
        private Label lbCustomerBirthday;
        private Label lbCustomerList;
        private TextBox txtCustomerId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerPassword;
        private TextBox txtCustomerCity;
        private TextBox txtCustomerCountry;
        private DateTimePicker dtcCustomerBirthday;
        private Button btCreate;
        private Button btUpdate;
        private Button btDelete;
        private Button btBack;
        private Label lbStatus;
        private TextBox txtCustomerStatus;
    }
}