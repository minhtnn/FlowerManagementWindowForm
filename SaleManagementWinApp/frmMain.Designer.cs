namespace SaleManagementWinApp
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            productMToolStripMenuItem = new ToolStripMenuItem();
            orderManagementToolStripMenuItem1 = new ToolStripMenuItem();
            customerManagementToolStripMenuItem1 = new ToolStripMenuItem();
            viewProfileToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            viewProfileToolStripMenuItem1 = new ToolStripMenuItem();
            viewOrderHistoryToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, customerToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productMToolStripMenuItem, orderManagementToolStripMenuItem1, customerManagementToolStripMenuItem1, viewProfileToolStripMenuItem, reportToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // productMToolStripMenuItem
            // 
            productMToolStripMenuItem.Name = "productMToolStripMenuItem";
            productMToolStripMenuItem.Size = new Size(247, 26);
            productMToolStripMenuItem.Text = "Product management";
            productMToolStripMenuItem.Click += productMToolStripMenuItem_Click;
            // 
            // orderManagementToolStripMenuItem1
            // 
            orderManagementToolStripMenuItem1.Name = "orderManagementToolStripMenuItem1";
            orderManagementToolStripMenuItem1.Size = new Size(247, 26);
            orderManagementToolStripMenuItem1.Text = "Order management";
            orderManagementToolStripMenuItem1.Click += orderManagementToolStripMenuItem1_Click;
            // 
            // customerManagementToolStripMenuItem1
            // 
            customerManagementToolStripMenuItem1.Name = "customerManagementToolStripMenuItem1";
            customerManagementToolStripMenuItem1.Size = new Size(247, 26);
            customerManagementToolStripMenuItem1.Text = "Customer management";
            customerManagementToolStripMenuItem1.Click += customerManagementToolStripMenuItem1_Click;
            // 
            // viewProfileToolStripMenuItem
            // 
            viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            viewProfileToolStripMenuItem.Size = new Size(247, 26);
            viewProfileToolStripMenuItem.Text = "View profile";
            viewProfileToolStripMenuItem.Click += viewProfileToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewProfileToolStripMenuItem1, viewOrderHistoryToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // viewProfileToolStripMenuItem1
            // 
            viewProfileToolStripMenuItem1.Name = "viewProfileToolStripMenuItem1";
            viewProfileToolStripMenuItem1.Size = new Size(212, 26);
            viewProfileToolStripMenuItem1.Text = "View profile";
            viewProfileToolStripMenuItem1.Click += viewProfileToolStripMenuItem1_Click;
            // 
            // viewOrderHistoryToolStripMenuItem
            // 
            viewOrderHistoryToolStripMenuItem.Name = "viewOrderHistoryToolStripMenuItem";
            viewOrderHistoryToolStripMenuItem.Size = new Size(212, 26);
            viewOrderHistoryToolStripMenuItem.Text = "View order history";
            viewOrderHistoryToolStripMenuItem.Click += viewOrderHistoryToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(74, 24);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(247, 26);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Main";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem productMToolStripMenuItem;
        private ToolStripMenuItem orderManagementToolStripMenuItem1;
        private ToolStripMenuItem customerManagementToolStripMenuItem1;
        private ToolStripMenuItem viewProfileToolStripMenuItem;
        private ToolStripMenuItem viewProfileToolStripMenuItem1;
        private ToolStripMenuItem viewOrderHistoryToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
    }
}