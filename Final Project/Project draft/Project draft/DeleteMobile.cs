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
    public partial class DeleteMobile : Form
    {
        //instantiating DBConnection class
        private DBConnection dbconnection = new DBConnection();
        //instantiating varaibles
        private DataTable mobileTable;

        public DeleteMobile()
        {
            InitializeComponent();
        }

        private void DeleteMobile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            string sqlString = "SELECT BRANDNAME, BRANDID FROM BRANDDETAILS";
            brandComboBox.ValueMember = "brandid";
            brandComboBox.DisplayMember = "brandname";
            brandComboBox.DataSource = dbconnection.selectTable(sqlString);
            brandComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }//end function DeleteMobile_Load 

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlString = "SELECT PRODUCTID ,PRODUCTNAME,PRICE,OS,DESCRIPTION FROM PRODUCTDETAILS WHERE BRANDID = ' " + brandComboBox.SelectedIndex + " '" + "ORDER BY PRODUCTID";
            mobileTable = dbconnection.selectTable(sqlString);
            mobileDataGridView.DataSource = mobileTable;
        }// end function brandComboBox_SelectedIndexChanged

        private void mobileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                var id = mobileDataGridView.CurrentRow.Cells[1].Value;
                string sqlString = "DELETE FROM PRODUCTDETAILS WHERE PRODUCTID = '" + id + "'";
                int result = dbconnection.updateTable(sqlString);
                if (result > 0)
                {
                   
                    string sqlString2 = "SELECT PRODUCTID ,PRODUCTNAME,PRICE,OS,DESCRIPTION FROM PRODUCTDETAILS WHERE BRANDID = ' " + brandComboBox.SelectedIndex + " '" + "ORDER BY PRODUCTID";
                    mobileTable = dbconnection.selectTable(sqlString2);
                    mobileDataGridView.DataSource = mobileTable;
                }
                else
                {
                    MessageBox.Show(dbconnection.DBErrors);
                }
                MessageBox.Show("Mobile Details deleted successfully.");
            }
        }//end function mobileDataGridView_CellContentClick
    }//end class
}//end namespace
