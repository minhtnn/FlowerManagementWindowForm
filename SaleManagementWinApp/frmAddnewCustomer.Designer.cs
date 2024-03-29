namespace SaleManagementWinApp
{
    partial class frmAddNewCustomer
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
            txtCustomerStatus = new TextBox();
            lbStatus = new Label();
            dtcCustomerBirthday = new DateTimePicker();
            txtCustomerCountry = new TextBox();
            txtCustomerCity = new TextBox();
            txtCustomerPassword = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerId = new TextBox();
            lbCustomerBirthday = new Label();
            lbCustomerCountry = new Label();
            lbCustomerCity = new Label();
            lbCustomerPassword = new Label();
            lbCustomerEmail = new Label();
            lbCustomerName = new Label();
            lbCustomerId = new Label();
            btCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Enabled = false;
            txtCustomerStatus.Location = new Point(407, 238);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.Size = new Size(106, 27);
            txtCustomerStatus.TabIndex = 37;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(338, 241);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 36;
            lbStatus.Text = "Status";
            // 
            // dtcCustomerBirthday
            // 
            dtcCustomerBirthday.Location = new Point(182, 348);
            dtcCustomerBirthday.Name = "dtcCustomerBirthday";
            dtcCustomerBirthday.Size = new Size(331, 27);
            dtcCustomerBirthday.TabIndex = 35;
            // 
            // txtCustomerCountry
            // 
            txtCustomerCountry.Location = new Point(407, 294);
            txtCustomerCountry.Name = "txtCustomerCountry";
            txtCustomerCountry.Size = new Size(106, 27);
            txtCustomerCountry.TabIndex = 34;
            // 
            // txtCustomerCity
            // 
            txtCustomerCity.Location = new Point(182, 294);
            txtCustomerCity.Name = "txtCustomerCity";
            txtCustomerCity.Size = new Size(111, 27);
            txtCustomerCity.TabIndex = 33;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Location = new Point(182, 238);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(111, 27);
            txtCustomerPassword.TabIndex = 32;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(182, 182);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(331, 27);
            txtCustomerEmail.TabIndex = 31;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(182, 127);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(331, 27);
            txtCustomerName.TabIndex = 30;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(182, 75);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(331, 27);
            txtCustomerId.TabIndex = 29;
            // 
            // lbCustomerBirthday
            // 
            lbCustomerBirthday.AutoSize = true;
            lbCustomerBirthday.Location = new Point(62, 348);
            lbCustomerBirthday.Name = "lbCustomerBirthday";
            lbCustomerBirthday.Size = new Size(67, 20);
            lbCustomerBirthday.TabIndex = 28;
            lbCustomerBirthday.Text = "Birthday:";
            // 
            // lbCustomerCountry
            // 
            lbCustomerCountry.AutoSize = true;
            lbCustomerCountry.Location = new Point(338, 297);
            lbCustomerCountry.Name = "lbCustomerCountry";
            lbCustomerCountry.Size = new Size(63, 20);
            lbCustomerCountry.TabIndex = 27;
            lbCustomerCountry.Text = "Country:";
            // 
            // lbCustomerCity
            // 
            lbCustomerCity.AutoSize = true;
            lbCustomerCity.Location = new Point(62, 297);
            lbCustomerCity.Name = "lbCustomerCity";
            lbCustomerCity.Size = new Size(37, 20);
            lbCustomerCity.TabIndex = 26;
            lbCustomerCity.Text = "City:";
            // 
            // lbCustomerPassword
            // 
            lbCustomerPassword.AutoSize = true;
            lbCustomerPassword.Location = new Point(62, 241);
            lbCustomerPassword.Name = "lbCustomerPassword";
            lbCustomerPassword.Size = new Size(73, 20);
            lbCustomerPassword.TabIndex = 25;
            lbCustomerPassword.Text = "Password:";
            // 
            // lbCustomerEmail
            // 
            lbCustomerEmail.AutoSize = true;
            lbCustomerEmail.Location = new Point(62, 185);
            lbCustomerEmail.Name = "lbCustomerEmail";
            lbCustomerEmail.Size = new Size(49, 20);
            lbCustomerEmail.TabIndex = 24;
            lbCustomerEmail.Text = "Email:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(62, 130);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 20);
            lbCustomerName.TabIndex = 23;
            lbCustomerName.Text = "Customer name:";
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(62, 75);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(92, 20);
            lbCustomerId.TabIndex = 22;
            lbCustomerId.Text = "Customer id:";
            // 
            // btCreate
            // 
            btCreate.Location = new Point(307, 409);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 29);
            btCreate.TabIndex = 38;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(419, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(btnCancel);
            Controls.Add(btCreate);
            Controls.Add(txtCustomerStatus);
            Controls.Add(lbStatus);
            Controls.Add(dtcCustomerBirthday);
            Controls.Add(txtCustomerCountry);
            Controls.Add(txtCustomerCity);
            Controls.Add(txtCustomerPassword);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lbCustomerBirthday);
            Controls.Add(lbCustomerCountry);
            Controls.Add(lbCustomerCity);
            Controls.Add(lbCustomerPassword);
            Controls.Add(lbCustomerEmail);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCustomerId);
            Name = "frmAddNewCustomer";
            Text = "Add new customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerStatus;
        private Label lbStatus;
        private DateTimePicker dtcCustomerBirthday;
        private TextBox txtCustomerCountry;
        private TextBox txtCustomerCity;
        private TextBox txtCustomerPassword;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerName;
        private TextBox txtCustomerId;
        private Label lbCustomerBirthday;
        private Label lbCustomerCountry;
        private Label lbCustomerCity;
        private Label lbCustomerPassword;
        private Label lbCustomerEmail;
        private Label lbCustomerName;
        private Label lbCustomerId;
        private Button btCreate;
        private Button btnCancel;
    }
}