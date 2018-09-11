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
    public partial class AdminAccount : Form
    {
        public AdminAccount()
        {
            InitializeComponent();
        }

        //when the same child is opened ...show the latest
        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }
        private void addAMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
               
                AddMobile addMobile = new AddMobile();
                //make the current form the parent of AddMobile
                addMobile.MdiParent = this;
                //bring up the form 
                addMobile.Show();
                DisposeAllButThis(addMobile);
            
        }

        private void updateProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                UpdateMobile updateMobile = new UpdateMobile();
                //make the current form the parent of UpdateMobile
                updateMobile.MdiParent = this;
                //bring up the form 
                updateMobile.Show();
                DisposeAllButThis(updateMobile);
        
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                DeleteMobile deleteMobile = new DeleteMobile();
                //make the current form the parent of DeleteMobile
                deleteMobile.MdiParent = this;
                //bring up the form 
                deleteMobile.Show();
            DisposeAllButThis(deleteMobile);
          

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //show the login form
            Login login = new Login();
            login.Show();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                ViewPurchases viewPurchases = new ViewPurchases();
                //make the current form the parent of DeleteMobile
                viewPurchases.MdiParent = this;
                //bring up the form 
                viewPurchases.Show();
            DisposeAllButThis(viewPurchases);


        }
    }
}
