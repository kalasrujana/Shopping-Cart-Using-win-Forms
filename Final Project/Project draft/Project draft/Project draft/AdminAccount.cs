using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_draft.Admin
{
    public partial class AdminAccount : Form
    {
        public AdminAccount()
        {
            InitializeComponent();
        }

        private void addAMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddMobile addMobile = new AddMobile();
            //make the current form the parent of AddMobile
            addMobile.MdiParent = this;
            //bring up the form 
            addMobile.Show();
        }

        private void updateProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMobile updateMobile = new UpdateMobile();
            updateMobile.MdiParent = this;
            updateMobile.Show();
        }
    }
}
