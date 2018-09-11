namespace Project_draft.Admin
{
    partial class AdminAccount
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageMobileDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAMobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMobileDetailsToolStripMenuItem,
            this.viewHistoryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageMobileDetailsToolStripMenuItem
            // 
            this.manageMobileDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAMobileToolStripMenuItem,
            this.updateProductDetailsToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.manageMobileDetailsToolStripMenuItem.Name = "manageMobileDetailsToolStripMenuItem";
            this.manageMobileDetailsToolStripMenuItem.Size = new System.Drawing.Size(163, 29);
            this.manageMobileDetailsToolStripMenuItem.Text = "&Manage Products";
            // 
            // addAMobileToolStripMenuItem
            // 
            this.addAMobileToolStripMenuItem.Name = "addAMobileToolStripMenuItem";
            this.addAMobileToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.addAMobileToolStripMenuItem.Text = "&Add Mobile";
            this.addAMobileToolStripMenuItem.Click += new System.EventHandler(this.addAMobileToolStripMenuItem_Click);
            // 
            // updateProductDetailsToolStripMenuItem
            // 
            this.updateProductDetailsToolStripMenuItem.Name = "updateProductDetailsToolStripMenuItem";
            this.updateProductDetailsToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.updateProductDetailsToolStripMenuItem.Text = "&Update Mobile";
            this.updateProductDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateProductDetailsToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.deleteProductToolStripMenuItem.Text = "&Delete Mobile";
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.viewHistoryToolStripMenuItem.Text = "&View History";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // AdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 574);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminAccount";
            this.Text = "AdminAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageMobileDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAMobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}