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
    public partial class ViewPurchases : Form
    {

        private string selectedBrand;

        private DBConnection dbconnection = new DBConnection();
        private DataTable mobileTable;
        public ViewPurchases()
        {
            InitializeComponent();
        }

        private void ViewPurchases_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            string sqlString = "SELECT BRANDNAME, BRANDID FROM BRANDDETAILS";
            productComboBox.ValueMember = "brandid";
            productComboBox.DisplayMember = "brandname";
            productComboBox.DataSource = dbconnection.selectTable(sqlString);
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBrand = productComboBox.GetItemText(productComboBox.SelectedItem);
            string sqlString = "SELECT USERNAME, BRANDNAME,PRODUCTNAME,PRICE,QUANTITY FROM ORDEREDPRODUCTS WHERE BRANDNAME = '" + selectedBrand + " '" + "ORDER BY USERNAME";
            mobileTable = dbconnection.selectTable(sqlString);
            mobileDataGridView.DataSource = mobileTable;

        }
    }
}
