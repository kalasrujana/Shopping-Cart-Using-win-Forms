namespace MobileStore
{
    partial class UserAccountMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewAndBuyProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAndBuyProductsToolStripMenuItem,
            this.viewOrdersToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1169, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewAndBuyProductsToolStripMenuItem
            // 
            this.viewAndBuyProductsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAndBuyProductsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.viewAndBuyProductsToolStripMenuItem.Name = "viewAndBuyProductsToolStripMenuItem";
            this.viewAndBuyProductsToolStripMenuItem.Size = new System.Drawing.Size(208, 27);
            this.viewAndBuyProductsToolStripMenuItem.Text = "&View and Buy Mobiles";
            this.viewAndBuyProductsToolStripMenuItem.Click += new System.EventHandler(this.viewAndBuyProductsToolStripMenuItem_Click);
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrdersToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(129, 27);
            this.viewOrdersToolStripMenuItem.Text = "&View Orders";
            this.viewOrdersToolStripMenuItem.Click += new System.EventHandler(this.viewOrdersToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // UserAccountMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1169, 524);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserAccountMainForm";
            this.Text = "UserAccountMainForm";
            this.Load += new System.EventHandler(this.UserAccountMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewAndBuyProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}