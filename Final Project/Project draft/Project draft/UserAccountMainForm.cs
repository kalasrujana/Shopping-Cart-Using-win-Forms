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
    public partial class UserAccountMainForm : Form
    {
        public UserAccountMainForm()
        {
            InitializeComponent();
        }

        public string uName;
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
        private void viewAndBuyProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccountForm userAccount = new UserAccountForm();
            //make the current form the parent of AddMobile
            userAccount.MdiParent = this;
            //bring up the form 
            userAccount.uName = uName;
            userAccount.Show();
            
            DisposeAllButThis(userAccount);

        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderHistoryForm orderHistory = new OrderHistoryForm();
            //make the current form the parent of AddMobile
            orderHistory.MdiParent = this;
            //bring up the form 
            orderHistory.uName = uName;
            orderHistory.Show();
            DisposeAllButThis(orderHistory);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //show the login form
            Login login = new Login();
            login.Show();
        }

        private void UserAccountMainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }
    }
}
