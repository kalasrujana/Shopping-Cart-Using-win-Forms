using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Runtime.Remoting.Contexts;
using MobileStore;

namespace MobileStore
{
    public partial class UserAccountForm : Form
    {
        //Declaring and initializing variables
        public int count = 0;
        public int row;
        //Declaring delegate
        public delegate void delPassData(TextBox text);

        public string uName;
        public UserAccountForm()
        {
            InitializeComponent();
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            
            userNameLabel.Text = uName;

            //for the full window
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //load Mobile data into ProductDetails gridview from database
            //instantiating the mobile class
            MobileClass loadMobileDetails = new MobileClass();
            loadMobileDetails.loadGridviewDetails(productsGridView);
          
        }

        private void addtocartButton_Click(object sender, EventArgs e)
        {
             bool isItemAdded = false;
            // when checked multiple and click on add to cart below gridview
            // to pass to second grid view
            foreach (DataGridViewRow item in productsGridView.Rows)
            {
                if ((bool)item.Cells[0].Value == true)  //when checked
                {
                    //to add row
                    int n = itemsaddedDataGridView.Rows.Add();
                    //to make checkbox tick
                    itemsaddedDataGridView.Rows[n].Cells[0].Value = true;
                    itemsaddedDataGridView.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                    itemsaddedDataGridView.Rows[n].Cells[2].Value = item.Cells[2].Value.ToString();
                    itemsaddedDataGridView.Rows[n].Cells[3].Value = item.Cells[6].Value.ToString();
                    itemsaddedDataGridView.Rows[n].Cells[4].Value = 1;


                    isItemAdded = true;
                }
            }

            //to print the total in total amount textbox
            if (itemsaddedDataGridView.Rows.Count > 1 && isItemAdded == true)
            {
                int sum = 0;
                // bottom add to cart is clicked count is >1
                for (int n = 0; n < (itemsaddedDataGridView.Rows.Count-1); n++)
                {
                    int quantity = Convert.ToInt32(itemsaddedDataGridView.Rows[n].Cells["quantitiesTextBox"].Value);
                    string price = itemsaddedDataGridView.Rows[n].Cells["priceTextBox"].Value.ToString();
                    int priceNoDollar = Convert.ToInt32(price.Substring(1, (price.Length - 1)));
                    int s = priceNoDollar * quantity;
                    sum = result(sum, s);
                }
                amountTextbox.Text = "$" + sum.ToString();

                alertLabel.Text = "Product added to cart successfully,Please checkout to pay.";
                alertLabel.ForeColor = System.Drawing.Color.Green;
            }
            else { 
                alertLabel.Text = "Please select the products and then add to cart";
                alertLabel.ForeColor = System.Drawing.Color.Red;
               }
            foreach (DataGridViewRow item in productsGridView.Rows)
            {
                if ((bool)item.Cells[0].Value == true)  //when checked
                {
                    item.Cells[0].Value = false;
                }
            }//end //to pass each item to gridview when clicked the add to cart in group box
        }// end function addtocartButton_Click

        // Lamda function. 
        Func<int, int, int> result = ( x, y) => x + y;
        private void productsGridView_MouseClick(object sender, MouseEventArgs e)
        {
            //to check the checkbox with tick and select the whole row when the mouse is clicked on any cell
            if ((bool)productsGridView.SelectedRows[0].Cells[0].Value == false) //if checkbox is not ticked
            {
                productsGridView.SelectedRows[0].Cells[0].Value = true; //to check
            }
            else
            {
                productsGridView.SelectedRows[0].Cells[0].Value = false;//to uncheck
            }
        }

        //when clicked on addtocart button in productgridview
        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                brandLabel.Text = this.productsGridView.CurrentRow.Cells[2].Value.ToString();
                productLabel.Text = this.productsGridView.CurrentRow.Cells[1].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])productsGridView.CurrentRow.Cells[3].Value);
                productImagePictureBox.Image = Image.FromStream(ms);
                productImagePictureBox.Show();
                priceLabel.Text = this.productsGridView.CurrentRow.Cells[6].Value.ToString();
                quantityTextBox.Text = "1";
            }

            if (e.ColumnIndex == 3)
            {
                UserAccountForm f = new UserAccountForm();
                MemoryStream ms = new MemoryStream((byte[])productsGridView.CurrentRow.Cells[3].Value);
                zoomImageForm zoomImageForm = new zoomImageForm();
                zoomImageForm.zoomPictureBox.Image = Image.FromStream(ms);
                zoomImageForm.StartPosition = FormStartPosition.CenterScreen;
                zoomImageForm.Show();
            }
        }//end function productsGridView_CellContentClick

        //to pass each item to gridview when clicked the add to cart in group box
        private void addcartButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(brandLabel.Text))
            {
                alertLabel.Text = "Please select the product and then add to cart.";
                alertLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(quantityTextBox.Text) > 0)
                    {
                        int row = 0;
                        itemsaddedDataGridView.Rows.Add();
                        row = itemsaddedDataGridView.Rows.Count - 2;
                        itemsaddedDataGridView["selectCheckBox", row].Value = true; //make the checkbox tick
                        itemsaddedDataGridView["brandTextBox", row].Value = brandLabel.Text;
                        itemsaddedDataGridView["productTextBox", row].Value = productLabel.Text;

                        string price = priceLabel.Text;
                        itemsaddedDataGridView["quantitiesTextBox", row].Value = quantityTextBox.Text;
                        itemsaddedDataGridView["priceTextBox", row].Value = price;

                        alertLabel.Text = "Product added to cart successfully.please checkout to pay";
                        alertLabel.ForeColor = System.Drawing.Color.Green;
                        brandLabel.Text = "";
                        productLabel.Text = "";
                        priceLabel.Text = "";
                        quantityTextBox.Text = "";
                        productsGridView.CurrentRow.Cells[0].Value = false;
                        productImagePictureBox.Hide();
                    }else
                    {
                        MessageBox.Show("Quantity should be a number");
                        quantityTextBox.Focus();
                    }
                    }
                catch (FormatException)
                {   
                    MessageBox.Show("Quantity should be a number");
                    quantityTextBox.Focus();
                }

            }
            //to calculate the total amount due
            if (itemsaddedDataGridView.Rows.Count > 1)
            {
                int sum = 0;
                int calSum = 0;
                // bottom add to cart is clicked count is >1
                for (int n = 0; n < (itemsaddedDataGridView.Rows.Count-1); n++)
                {
                    int quantity = Convert.ToInt32(itemsaddedDataGridView.Rows[n].Cells["quantitiesTextBox"].Value.ToString());
                    string eachPrice = itemsaddedDataGridView.Rows[n].Cells["priceTextBox"].Value.ToString();
                    int eachPriceNoDollar = Convert.ToInt32(eachPrice.Substring(1,(eachPrice.Length-1)));
                    calSum = eachPriceNoDollar * quantity;
                    sum = result(sum, calSum);
                }
                amountTextbox.Text = "$" + sum.ToString();
            }
        }

        //pass gridvalues on checkout button click
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(amountTextbox.Text))
            {
                MessageBox.Show("You have not added any produts to cart.", "Invalid Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<PassGridValuesBetweenForms> passValue = new List<PassGridValuesBetweenForms>();
                foreach (DataGridViewRow item in itemsaddedDataGridView.Rows)
                {
                    if (Convert.ToBoolean(item.Cells[0].Value))  //if checked
                    {
                        passValue.Add(new PassGridValuesBetweenForms
                        {
                            //brand from class passvalueclassbetweenforms
                            Brand = item.Cells["brandTextBox"].Value.ToString(),
                            ProductName = item.Cells["productTextBox"].Value.ToString(),
                            Price = item.Cells["priceTextBox"].Value.ToString(),
                            Quantity = item.Cells["quantitiesTextBox"].Value.ToString(),
                        });
                    }
                }
                //now pass the list values to the cartandcheckout form
                CartAndCheckoutForm mobileCart = new CartAndCheckoutForm();
                mobileCart.Values = passValue;
                mobileCart.uName = uName;

                delPassData del = new delPassData(mobileCart.funData);
                del(this.amountTextbox);

                mobileCart.Show();
                this.Hide();
            }
        }//end function checkoutButton_Click

        //On search Button Click
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                MobileClass mobileClass = new MobileClass();
                string sqlString = "select * from ProductDetails where ProductName like '" + searchTextBox.Text + "%'";
                mobileClass.searchAndloadGridviewDetails(productsGridView, sqlString);
                searchTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No products are there with the search.");
            }
        }

        //for Checkbox filter
        private void filterButton_Click(object sender, EventArgs e)
        {
            string filterdata = "";
            if (appleCheckBox.Checked)
            {
                if (samsungCheckBox.Checked || motorolaCheckBox.Checked)
                {
                    filterdata = "'1',";
                }
                else
                {
                    filterdata = "'1'";
                }
            }

            if (samsungCheckBox.Checked)
            {
                if (motorolaCheckBox.Checked)
                {
                    filterdata = filterdata + "'3',";
                }
                else
                {
                    filterdata = filterdata + "'3'";
                }
            }

            if (motorolaCheckBox.Checked)
            {
                filterdata = filterdata + "'2'";
            }

            MobileClass mobileClass = new MobileClass();
            string sqlString = "select * from ProductDetails where BrandID in(" + filterdata + ")";
            mobileClass.searchAndloadGridviewDetails(productsGridView, sqlString);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to recalculate amount if the quantity is changed in itemsaddedDataGrid
        private void itemsaddedDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 4 && itemsaddedDataGridView.Rows[0].Cells[3].Value !=null)
            {
                int sum = 0;
                for (int i = 0; i < itemsaddedDataGridView.Rows.Count - 1; i++)
                {
                    if(itemsaddedDataGridView.Rows[i].Cells[3].Value != null) { 
                    string price = itemsaddedDataGridView.Rows[i].Cells[3].Value.ToString();
                    int priceNoDollar = Convert.ToInt32(price.Substring(1, (price.Length-1)));
                    int quantity = Convert.ToInt32(itemsaddedDataGridView.Rows[i].Cells[4].Value);
                    sum = sum + (priceNoDollar * quantity);
                    }
                }

                amountTextbox.Text = "$" + sum.ToString();
            }
        }


        //to comapare two products when clicked on compare button
        private void compareButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            int row;

            CompareProductsForm compareForm = new CompareProductsForm();
            compareForm.uName = uName;
            foreach (DataGridViewRow item in productsGridView.Rows)
            {
                if ((bool)item.Cells[0].Value == true)  //when checked
                {
                    count = count + 1;
                    row = item.Index;  //to get row number in productsgridview
                    if (String.IsNullOrEmpty(compareForm.brandTextBox1.Text))
                    {
                        compareForm.productTextBox1.Text = productsGridView.Rows[row].Cells[1].Value.ToString();
                        compareForm.brandTextBox1.Text = productsGridView.Rows[row].Cells[2].Value.ToString();
                        compareForm.osTextBox1.Text = productsGridView.Rows[row].Cells[4].Value.ToString();
                        compareForm.descTextBox1.Text = productsGridView.Rows[row].Cells[5].Value.ToString();
                        string price = productsGridView.Rows[row].Cells[6].Value.ToString();
                        int priceNoDollar = Convert.ToInt32(price.Substring(1, (price.Length-1)));
                        compareForm.priceTextBox1.Text = "$" + priceNoDollar;
                    }
                    else
                    {
                        compareForm.brandTextBox2.Text = productsGridView.Rows[row].Cells[2].Value.ToString();
                        compareForm.productTextBox2.Text = productsGridView.Rows[row].Cells[1].Value.ToString();
                        compareForm.osTextBox2.Text = productsGridView.Rows[row].Cells[4].Value.ToString();
                        compareForm.descTextBox2.Text = productsGridView.Rows[row].Cells[5].Value.ToString();
                        string price = productsGridView.Rows[row].Cells[6].Value.ToString();
                        int priceNoDollar = Convert.ToInt32(price.Substring(1, (price.Length-1)));
                        compareForm.priceTextBox2.Text = "$" + priceNoDollar;
                    }
                }
            }  //end foreach
                if (count > 2 || count <= 1)
                {
                    MessageBox.Show("Please select 2 products to compare", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    compareForm.Hide();
                }
                else
                {
                    compareForm.ShowDialog();
                }
        }//end function compareButton_Click

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in itemsaddedDataGridView.SelectedRows)
            {
                itemsaddedDataGridView.Rows.RemoveAt(row.Index);
                int sum = 0;
                for (int n = 0; n < (itemsaddedDataGridView.Rows.Count - 1); n++)
                {
                    int quantity = Convert.ToInt32(itemsaddedDataGridView.Rows[n].Cells["quantitiesTextBox"].Value);
                    string price = itemsaddedDataGridView.Rows[n].Cells["priceTextBox"].Value.ToString();
                    int priceNoDollar = Convert.ToInt32(price.Substring(1, (price.Length - 1)));
                    int s = priceNoDollar * quantity;
                    sum = result(sum, s);
                }
                amountTextbox.Text = "$" + sum.ToString();
            }
        }
    }//end class
}//end namespace
