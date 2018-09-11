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
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        public string uName;

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            userLabel.Text = uName;

            MobileClass mobileClass = new MobileClass();
            string sqlString = "select * from OrderedProducts where UserName='"+userLabel.Text+"'";
            
            DataTable orderTable = mobileClass.getTable(sqlString);
            foreach(DataRow row in orderTable.Rows)
            {
                int numberofRows = orderedProsuctsDatagridview.Rows.Add();
                orderedProsuctsDatagridview.Rows[numberofRows].Cells[0].Value = row["BrandName"].ToString();
                orderedProsuctsDatagridview.Rows[numberofRows].Cells[1].Value = row["ProductName"].ToString();
                orderedProsuctsDatagridview.Rows[numberofRows].Cells[2].Value = row["Quantity"].ToString();
                orderedProsuctsDatagridview.Rows[numberofRows].Cells[3].Value = "$" + row["Price"].ToString();
            }
        }
    }
}
