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
    public partial class UpdateMobile : Form
    {
        //instanting varaibles
        private DataTable mobileTable;
        private string selectedName;

        //instantiang DBConnection class
        private DBConnection dbconnection = new DBConnection();

        public UpdateMobile()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateMobile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            string sqlString = "SELECT BRANDNAME, BRANDID FROM BRANDDETAILS";
            brandComboBox.ValueMember = "brandid";
            brandComboBox.DisplayMember = "brandname";
            // to load drop down with brand names
            brandComboBox.DataSource = dbconnection.selectTable(sqlString);
            brandComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mobileComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }//end function UpdateMobile_Load

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlString = "SELECT PRODUCTID ,PRODUCTNAME,PRICE,OS,DESCRIPTION FROM PRODUCTDETAILS WHERE BRANDID = ' " + brandComboBox.SelectedIndex + " '" + "ORDER BY PRODUCTID";
            mobileComboBox.ValueMember = "id";
            mobileComboBox.DisplayMember = "ProductName";
            // to load the product names for selected brand name
            mobileTable = dbconnection.selectTable(sqlString);
            mobileComboBox.DataSource = mobileTable;

        }// end function brandComboBox_SelectedIndexChanged

        private void searchButton_Click(object sender, EventArgs e)
        {
            selectedName = mobileComboBox.GetItemText(mobileComboBox.SelectedItem);
            foreach (DataRow row in mobileTable.Rows) {

                if(row["ProductName"].ToString().Equals(selectedName))
                {
                    priceTextBox.Text = row["Price"].ToString();
                    osTextBox.Text = row["OS"].ToString();
                    descTextBox.Text = row["Description"].ToString();
                 }

                }//end foreach
        }//end function searchButton_Click

        private void updateButton_Click(object sender, EventArgs e)
        {
            string sqlString = "UPDATE PRODUCTDETAILS set PRICE = '" + priceTextBox.Text + "' , OS = '" + osTextBox.Text  + "', DESCRIPTION = '" + descTextBox.Text +"'where PRODUCTNAME ='" + selectedName + "'" ;
            int result = dbconnection.updateTable(sqlString);

            if (result > 0)
            {
                MessageBox.Show("Mobile Details Updated successfully.");
                brandComboBox.SelectedIndex = 0;
                mobileComboBox.DataSource = null;
                mobileComboBox.ResetText();
                priceTextBox.Text = "";
                osTextBox.Text = "";
                descTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please provide the correct inputs:price as number.");
            }
        }//end function updateButton_Click
    }//end class

}//end namespace