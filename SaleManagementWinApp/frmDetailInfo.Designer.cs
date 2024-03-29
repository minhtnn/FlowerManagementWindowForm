namespace SaleManagementWinApp
{
    partial class frmDetailInfo
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
            lbMemberID = new Label();
            lbMemberName = new Label();
            lbMemberEmail = new Label();
            lbMemberCity = new Label();
            lbMemberCountry = new Label();
            lbMemberPassword = new Label();
            lbMemberBirthday = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberCity = new TextBox();
            txtMemberCountry = new TextBox();
            txtMemberPassword = new TextBox();
            btEdit = new Button();
            btSave = new Button();
            btBack = new Button();
            dtpBirthday = new DateTimePicker();
            lbStatus = new Label();
            txtStatus = new TextBox();
            btnChangePassword = new Button();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(47, 53);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(24, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(303, 53);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(69, 20);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Fullname";
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new Point(47, 100);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new Size(46, 20);
            lbMemberEmail.TabIndex = 2;
            lbMemberEmail.Text = "Email";
            // 
            // lbMemberCity
            // 
            lbMemberCity.AutoSize = true;
            lbMemberCity.Location = new Point(47, 150);
            lbMemberCity.Name = "lbMemberCity";
            lbMemberCity.Size = new Size(34, 20);
            lbMemberCity.TabIndex = 3;
            lbMemberCity.Text = "City";
            // 
            // lbMemberCountry
            // 
            lbMemberCountry.AutoSize = true;
            lbMemberCountry.Location = new Point(350, 150);
            lbMemberCountry.Name = "lbMemberCountry";
            lbMemberCountry.Size = new Size(60, 20);
            lbMemberCountry.TabIndex = 4;
            lbMemberCountry.Text = "Country";
            // 
            // lbMemberPassword
            // 
            lbMemberPassword.AutoSize = true;
            lbMemberPassword.Location = new Point(47, 200);
            lbMemberPassword.Name = "lbMemberPassword";
            lbMemberPassword.Size = new Size(70, 20);
            lbMemberPassword.TabIndex = 5;
            lbMemberPassword.Text = "Password";
            // 
            // lbMemberBirthday
            // 
            lbMemberBirthday.AutoSize = true;
            lbMemberBirthday.Location = new Point(47, 250);
            lbMemberBirthday.Name = "lbMemberBirthday";
            lbMemberBirthday.Size = new Size(64, 20);
            lbMemberBirthday.TabIndex = 6;
            lbMemberBirthday.Text = "Birthday";
            // 
            // txtMemberID
            // 
            txtMemberID.Enabled = false;
            txtMemberID.Location = new Point(145, 50);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(139, 27);
            txtMemberID.TabIndex = 7;
            txtMemberID.TextChanged += txtMemberID_TextChanged;
            // 
            // txtMemberName
            // 
            txtMemberName.Enabled = false;
            txtMemberName.Location = new Point(378, 53);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(227, 27);
            txtMemberName.TabIndex = 8;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Enabled = false;
            txtMemberEmail.Location = new Point(145, 100);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(460, 27);
            txtMemberEmail.TabIndex = 9;
            // 
            // txtMemberCity
            // 
            txtMemberCity.Enabled = false;
            txtMemberCity.Location = new Point(145, 147);
            txtMemberCity.Name = "txtMemberCity";
            txtMemberCity.Size = new Size(172, 27);
            txtMemberCity.TabIndex = 10;
            // 
            // txtMemberCountry
            // 
            txtMemberCountry.Enabled = false;
            txtMemberCountry.Location = new Point(420, 147);
            txtMemberCountry.Name = "txtMemberCountry";
            txtMemberCountry.Size = new Size(185, 27);
            txtMemberCountry.TabIndex = 11;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.Enabled = false;
            txtMemberPassword.Location = new Point(145, 197);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(460, 27);
            txtMemberPassword.TabIndex = 12;
            txtMemberPassword.UseSystemPasswordChar = true;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(303, 311);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 14;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btSave
            // 
            btSave.Enabled = false;
            btSave.Location = new Point(408, 311);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 15;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(511, 311);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 16;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Enabled = false;
            dtpBirthday.Location = new Point(145, 245);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(277, 27);
            dtpBirthday.TabIndex = 17;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(453, 249);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 19;
            lbStatus.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(511, 245);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(94, 27);
            txtStatus.TabIndex = 20;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(145, 311);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(152, 29);
            btnChangePassword.TabIndex = 21;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // frmDetailInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 360);
            Controls.Add(btnChangePassword);
            Controls.Add(txtStatus);
            Controls.Add(lbStatus);
            Controls.Add(dtpBirthday);
            Controls.Add(btBack);
            Controls.Add(btSave);
            Controls.Add(btEdit);
            Controls.Add(txtMemberPassword);
            Controls.Add(txtMemberCountry);
            Controls.Add(txtMemberCity);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberBirthday);
            Controls.Add(lbMemberPassword);
            Controls.Add(lbMemberCountry);
            Controls.Add(lbMemberCity);
            Controls.Add(lbMemberEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Name = "frmDetailInfo";
            Text = "Detail Information";
            Load += frmDetailInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbMemberEmail;
        private Label lbMemberCity;
        private Label lbMemberCountry;
        private Label lbMemberPassword;
        private Label lbMemberBirthday;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtMemberEmail;
        private TextBox txtMemberCity;
        private TextBox txtMemberCountry;
        private TextBox txtMemberPassword;
        private Button btEdit;
        private Button btSave;
        private Button btBack;
        private DateTimePicker dtpBirthday;
        private Label lbStatus;
        private TextBox txtStatus;
        private Button btnChangePassword;
    }
}