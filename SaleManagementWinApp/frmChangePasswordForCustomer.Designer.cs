namespace SaleManagementWinApp
{
    partial class frmChangePasswordForCustomer
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
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btCancel = new Button();
            btChangePassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Old password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "New password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 130);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm password:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(190, 28);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(273, 27);
            txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(190, 81);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(273, 27);
            txtNewPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(190, 127);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(273, 27);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(369, 169);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 6;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btChangePassword
            // 
            btChangePassword.Location = new Point(269, 169);
            btChangePassword.Name = "btChangePassword";
            btChangePassword.Size = new Size(94, 29);
            btChangePassword.TabIndex = 7;
            btChangePassword.Text = "Change";
            btChangePassword.UseVisualStyleBackColor = true;
            btChangePassword.Click += btChangePassword_Click;
            // 
            // frmChangePasswordForCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 210);
            Controls.Add(btChangePassword);
            Controls.Add(btCancel);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChangePasswordForCustomer";
            Text = "Change password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btCancel;
        private Button btChangePassword;
    }
}