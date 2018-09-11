using MobileStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class CartAndCheckoutForm : Form
    {
        public CartAndCheckoutForm()
        {
            InitializeComponent();
        }

        public string uName;
        //list
        public List<PassGridValuesBetweenForms> Values { get; set; }

        //append
        public void AddtoGrid(List<PassGridValuesBetweenForms> val)
        {
            if (val != null)
            {
                foreach (PassGridValuesBetweenForms item in val)
                {
                    //to get the index of the inserted row
                    int rowNumber = cartDataGridView.Rows.Add();
                    //To load rows data into gridview..mapping
                    cartDataGridView.Rows[rowNumber].Cells[0].Value = item.Brand;
                    cartDataGridView.Rows[rowNumber].Cells[1].Value = item.ProductName;
                    cartDataGridView.Rows[rowNumber].Cells[2].Value = item.Price;
                    cartDataGridView.Rows[rowNumber].Cells[3].Value = item.Quantity;
                }
            }
        }
        public string usernameString = "";
        private void CartAndCheckoutForm_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            userLable.Text = uName;
            usernameString = userLable.Text;

            //to show the grid values on to other form
            AddtoGrid(Values);
            
            //to pass total price data
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["UserAccountForm"];
            //AmountLabel.Text = ((UserAccountForm)f).amountTextbox.Text;
        }

        public void funData(TextBox txtform1)
        {
            AmountLabel.Text = txtform1.Text;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cardNumberTextBox.Text) || String.IsNullOrEmpty(cvvTextBox.Text) || String.IsNullOrEmpty(addressTextBox.Text))
            {
                showLabel.Text = "Please enter payment information to pay.";
                showLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MessageBox.Show("You have ordered successfully.Happy Shopping!!");

                //To insert into ordered product table
                MobileClass mobileClass = new MobileClass();
                DBConnection dbConnection = new DBConnection();
                for (int n = 0; n < (cartDataGridView.Rows.Count); n++)
                {
                    string brandName = cartDataGridView.Rows[n].Cells[0].Value.ToString();
                    string name = cartDataGridView.Rows[n].Cells[1].Value.ToString();
                    string totallValue = cartDataGridView.Rows[n].Cells[2].Value.ToString();
                    int price = Convert.ToInt32(totallValue.Substring(1, (totallValue.Length - 1)));
                    int quantity = Convert.ToInt32(cartDataGridView.Rows[n].Cells[3].Value);

                    int result = mobileClass.insertMobile(brandName, name, price, quantity, usernameString);
                }
                this.Hide();
            }
                    
    }

        private void cardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cvvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
