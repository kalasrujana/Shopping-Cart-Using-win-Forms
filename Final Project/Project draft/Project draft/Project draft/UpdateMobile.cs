using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_draft
{
    public partial class UpdateMobile : Form
    {
        private DataTable brandTable;
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
            //brandTable = dbconnection.selectBrandTable();

        }
    }
}
