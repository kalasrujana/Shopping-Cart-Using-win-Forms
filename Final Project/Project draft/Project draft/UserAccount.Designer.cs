namespace MobileStore
{
    partial class UserAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountForm));
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.motorolaCheckBox = new System.Windows.Forms.CheckBox();
            this.samsungCheckBox = new System.Windows.Forms.CheckBox();
            this.appleCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.addcartButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productImagePictureBox = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.itemsaddedDataGridView = new System.Windows.Forms.DataGridView();
            this.selectCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitiesTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtocartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsaddedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column5,
            this.dataGridViewTextBoxColumn7,
            this.Column8});
            this.productsGridView.Location = new System.Drawing.Point(409, 93);
            this.productsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(853, 201);
            this.productsGridView.TabIndex = 1;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            this.productsGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productsGridView_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ProductName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BrandName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Image";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "OperatingSystem";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "AddToCart";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Add To Cart";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(445, 57);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(442, 26);
            this.searchTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Controls.Add(this.motorolaCheckBox);
            this.groupBox1.Controls.Add(this.samsungCheckBox);
            this.groupBox1.Controls.Add(this.appleCheckBox);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(48, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(229, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Products by Brand";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filterButton.Location = new System.Drawing.Point(27, 209);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(174, 33);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter Products";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // motorolaCheckBox
            // 
            this.motorolaCheckBox.AutoSize = true;
            this.motorolaCheckBox.Location = new System.Drawing.Point(27, 154);
            this.motorolaCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motorolaCheckBox.Name = "motorolaCheckBox";
            this.motorolaCheckBox.Size = new System.Drawing.Size(92, 23);
            this.motorolaCheckBox.TabIndex = 2;
            this.motorolaCheckBox.Text = "Motorola";
            this.motorolaCheckBox.UseVisualStyleBackColor = true;
            // 
            // samsungCheckBox
            // 
            this.samsungCheckBox.AutoSize = true;
            this.samsungCheckBox.Location = new System.Drawing.Point(27, 106);
            this.samsungCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.samsungCheckBox.Name = "samsungCheckBox";
            this.samsungCheckBox.Size = new System.Drawing.Size(89, 23);
            this.samsungCheckBox.TabIndex = 1;
            this.samsungCheckBox.Text = "Samsung";
            this.samsungCheckBox.UseVisualStyleBackColor = true;
            // 
            // appleCheckBox
            // 
            this.appleCheckBox.AutoSize = true;
            this.appleCheckBox.Location = new System.Drawing.Point(27, 55);
            this.appleCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appleCheckBox.Name = "appleCheckBox";
            this.appleCheckBox.Size = new System.Drawing.Size(72, 23);
            this.appleCheckBox.TabIndex = 0;
            this.appleCheckBox.Text = "Apple";
            this.appleCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.priceLabel);
            this.groupBox2.Controls.Add(this.productLabel);
            this.groupBox2.Controls.Add(this.brandLabel);
            this.groupBox2.Controls.Add(this.addcartButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.productImagePictureBox);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(13, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(357, 274);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(240, 159);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(95, 26);
            this.quantityTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(236, 120);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 19);
            this.priceLabel.TabIndex = 10;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(236, 76);
            this.productLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(0, 19);
            this.productLabel.TabIndex = 8;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(236, 33);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(0, 19);
            this.brandLabel.TabIndex = 7;
            // 
            // addcartButton
            // 
            this.addcartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addcartButton.Location = new System.Drawing.Point(202, 225);
            this.addcartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addcartButton.Name = "addcartButton";
            this.addcartButton.Size = new System.Drawing.Size(100, 33);
            this.addcartButton.TabIndex = 6;
            this.addcartButton.Text = "Confirm";
            this.addcartButton.UseVisualStyleBackColor = false;
            this.addcartButton.Click += new System.EventHandler(this.addcartButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand :";
            // 
            // productImagePictureBox
            // 
            this.productImagePictureBox.Location = new System.Drawing.Point(10, 33);
            this.productImagePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productImagePictureBox.Name = "productImagePictureBox";
            this.productImagePictureBox.Size = new System.Drawing.Size(134, 225);
            this.productImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.productImagePictureBox.TabIndex = 0;
            this.productImagePictureBox.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightBlue;
            this.searchButton.Location = new System.Drawing.Point(914, 57);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(232, 33);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search by Product Name";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemsaddedDataGridView
            // 
            this.itemsaddedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsaddedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsaddedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectCheckBox,
            this.productTextBox,
            this.brandTextBox,
            this.priceTextBox,
            this.quantitiesTextBox});
            this.itemsaddedDataGridView.Location = new System.Drawing.Point(389, 355);
            this.itemsaddedDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemsaddedDataGridView.Name = "itemsaddedDataGridView";
            this.itemsaddedDataGridView.Size = new System.Drawing.Size(853, 217);
            this.itemsaddedDataGridView.TabIndex = 7;
            this.itemsaddedDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsaddedDataGridView_CellValueChanged);
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.HeaderText = "Select";
            this.selectCheckBox.Name = "selectCheckBox";
            // 
            // productTextBox
            // 
            this.productTextBox.HeaderText = "ProductName";
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            // 
            // brandTextBox
            // 
            this.brandTextBox.HeaderText = "BrandName";
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.HeaderText = "Price";
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            // 
            // quantitiesTextBox
            // 
            this.quantitiesTextBox.HeaderText = "Quantity";
            this.quantitiesTextBox.Name = "quantitiesTextBox";
            // 
            // addtocartButton
            // 
            this.addtocartButton.BackColor = System.Drawing.Color.LightBlue;
            this.addtocartButton.Location = new System.Drawing.Point(726, 304);
            this.addtocartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addtocartButton.Name = "addtocartButton";
            this.addtocartButton.Size = new System.Drawing.Size(117, 36);
            this.addtocartButton.TabIndex = 8;
            this.addtocartButton.Text = "Add To Cart";
            this.addtocartButton.UseVisualStyleBackColor = false;
            this.addtocartButton.Click += new System.EventHandler(this.addtocartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(703, 582);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Amount";
            // 
            // amountTextbox
            // 
            this.amountTextbox.BackColor = System.Drawing.Color.LightBlue;
            this.amountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTextbox.Location = new System.Drawing.Point(813, 582);
            this.amountTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.ReadOnly = true;
            this.amountTextbox.Size = new System.Drawing.Size(146, 19);
            this.amountTextbox.TabIndex = 10;
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.LightBlue;
            this.checkoutButton.Location = new System.Drawing.Point(1053, 575);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(162, 33);
            this.checkoutButton.TabIndex = 11;
            this.checkoutButton.Text = "CheckOut";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Location = new System.Drawing.Point(957, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Logged In User:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.LightBlue;
            this.userNameLabel.Location = new System.Drawing.Point(1072, 9);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 19);
            this.userNameLabel.TabIndex = 13;
            // 
            // compareButton
            // 
            this.compareButton.BackColor = System.Drawing.Color.LightBlue;
            this.compareButton.Location = new System.Drawing.Point(928, 302);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(117, 36);
            this.compareButton.TabIndex = 14;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = false;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Location = new System.Drawing.Point(441, 324);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 19);
            this.alertLabel.TabIndex = 15;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightBlue;
            this.deleteButton.Location = new System.Drawing.Point(435, 580);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 28);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1320, 738);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addtocartButton);
            this.Controls.Add(this.itemsaddedDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.productsGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccountForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "UserAccount";
            this.Load += new System.EventHandler(this.UserAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsaddedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView itemsaddedDataGridView;
        private System.Windows.Forms.Button addtocartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox productImagePictureBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Button addcartButton;
        private System.Windows.Forms.Button checkoutButton;
        public System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.CheckBox motorolaCheckBox;
        private System.Windows.Forms.CheckBox samsungCheckBox;
        private System.Windows.Forms.CheckBox appleCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitiesTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.Button deleteButton;
    }
}

