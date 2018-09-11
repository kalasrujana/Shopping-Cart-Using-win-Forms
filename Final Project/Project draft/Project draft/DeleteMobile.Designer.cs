namespace MobileStore
{
    partial class DeleteMobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMobile));
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mobileDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // brandComboBox
            // 
            this.brandComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(637, 97);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(147, 31);
            this.brandComboBox.TabIndex = 0;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(457, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Brand";
            // 
            // mobileDataGridView
            // 
            this.mobileDataGridView.AllowUserToAddRows = false;
            this.mobileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mobileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mobileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.OS,
            this.Description,
            this.deleteButton});
            this.mobileDataGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.mobileDataGridView.Location = new System.Drawing.Point(315, 177);
            this.mobileDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mobileDataGridView.Name = "mobileDataGridView";
            this.mobileDataGridView.ReadOnly = true;
            this.mobileDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mobileDataGridView.RowTemplate.Height = 28;
            this.mobileDataGridView.Size = new System.Drawing.Size(786, 375);
            this.mobileDataGridView.TabIndex = 2;
            this.mobileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mobileDataGridView_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductId";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // OS
            // 
            this.OS.DataPropertyName = "os";
            this.OS.HeaderText = "OS";
            this.OS.Name = "OS";
            this.OS.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // deleteButton
            // 
            this.deleteButton.DataPropertyName = "Delete";
            this.deleteButton.HeaderText = "Delete";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1924, 641);
            this.Controls.Add(this.mobileDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brandComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeleteMobile";
            this.Text = "DeleteMobile";
            this.Load += new System.EventHandler(this.DeleteMobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mobileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
    }
}