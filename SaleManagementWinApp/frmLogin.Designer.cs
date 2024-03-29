namespace SaleManagementWinApp
{
    partial class frmLogin
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            btClear = new Button();
            btExit = new Button();
            cbShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(154, 147);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 4;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(263, 147);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 5;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(374, 147);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 29);
            btExit.TabIndex = 6;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(158, 114);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(134, 24);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Show password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 185);
            Controls.Add(cbShowPassword);
            Controls.Add(btExit);
            Controls.Add(btClear);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btLogin;
        private Button btClear;
        private Button btExit;
        private CheckBox cbShowPassword;
    }
}