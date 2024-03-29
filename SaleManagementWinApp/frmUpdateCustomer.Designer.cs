namespace SaleManagementWinApp
{
    partial class frmUpdateCustomer
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
            btnCancel = new Button();
            btUpdate = new Button();
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
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(395, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(283, 394);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 56;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtCustomerStatus
            // 
            txtCustomerStatus.Location = new Point(383, 223);
            txtCustomerStatus.Name = "txtCustomerStatus";
            txtCustomerStatus.Size = new Size(106, 27);
            txtCustomerStatus.TabIndex = 55;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(314, 226);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 54;
            lbStatus.Text = "Status";
            // 
            // dtcCustomerBirthday
            // 
            dtcCustomerBirthday.Location = new Point(158, 333);
            dtcCustomerBirthday.Name = "dtcCustomerBirthday";
            dtcCustomerBirthday.Size = new Size(331, 27);
            dtcCustomerBirthday.TabIndex = 53;
            // 
            // txtCustomerCountry
            // 
            txtCustomerCountry.Location = new Point(383, 279);
            txtCustomerCountry.Name = "txtCustomerCountry";
            txtCustomerCountry.Size = new Size(106, 27);
            txtCustomerCountry.TabIndex = 52;
            // 
            // txtCustomerCity
            // 
            txtCustomerCity.Location = new Point(158, 279);
            txtCustomerCity.Name = "txtCustomerCity";
            txtCustomerCity.Size = new Size(111, 27);
            txtCustomerCity.TabIndex = 51;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Location = new Point(158, 223);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(111, 27);
            txtCustomerPassword.TabIndex = 50;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(158, 167);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(331, 27);
            txtCustomerEmail.TabIndex = 49;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(158, 112);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(331, 27);
            txtCustomerName.TabIndex = 48;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(158, 60);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(331, 27);
            txtCustomerId.TabIndex = 47;
            // 
            // lbCustomerBirthday
            // 
            lbCustomerBirthday.AutoSize = true;
            lbCustomerBirthday.Location = new Point(38, 333);
            lbCustomerBirthday.Name = "lbCustomerBirthday";
            lbCustomerBirthday.Size = new Size(67, 20);
            lbCustomerBirthday.TabIndex = 46;
            lbCustomerBirthday.Text = "Birthday:";
            // 
            // lbCustomerCountry
            // 
            lbCustomerCountry.AutoSize = true;
            lbCustomerCountry.Location = new Point(314, 282);
            lbCustomerCountry.Name = "lbCustomerCountry";
            lbCustomerCountry.Size = new Size(63, 20);
            lbCustomerCountry.TabIndex = 45;
            lbCustomerCountry.Text = "Country:";
            // 
            // lbCustomerCity
            // 
            lbCustomerCity.AutoSize = true;
            lbCustomerCity.Location = new Point(38, 282);
            lbCustomerCity.Name = "lbCustomerCity";
            lbCustomerCity.Size = new Size(37, 20);
            lbCustomerCity.TabIndex = 44;
            lbCustomerCity.Text = "City:";
            // 
            // lbCustomerPassword
            // 
            lbCustomerPassword.AutoSize = true;
            lbCustomerPassword.Location = new Point(38, 226);
            lbCustomerPassword.Name = "lbCustomerPassword";
            lbCustomerPassword.Size = new Size(73, 20);
            lbCustomerPassword.TabIndex = 43;
            lbCustomerPassword.Text = "Password:";
            // 
            // lbCustomerEmail
            // 
            lbCustomerEmail.AutoSize = true;
            lbCustomerEmail.Location = new Point(38, 170);
            lbCustomerEmail.Name = "lbCustomerEmail";
            lbCustomerEmail.Size = new Size(49, 20);
            lbCustomerEmail.TabIndex = 42;
            lbCustomerEmail.Text = "Email:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(38, 115);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 20);
            lbCustomerName.TabIndex = 41;
            lbCustomerName.Text = "Customer name:";
            // 
            // lbCustomerId
            // 
            lbCustomerId.AutoSize = true;
            lbCustomerId.Location = new Point(38, 60);
            lbCustomerId.Name = "lbCustomerId";
            lbCustomerId.Size = new Size(92, 20);
            lbCustomerId.TabIndex = 40;
            lbCustomerId.Text = "Customer id:";
            // 
            // frmUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 431);
            Controls.Add(btnCancel);
            Controls.Add(btUpdate);
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
            Name = "frmUpdateCustomer";
            Text = "Update customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btUpdate;
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
    }
}