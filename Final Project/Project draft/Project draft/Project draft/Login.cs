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

namespace Project_draft.Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Shows a message if any of the fields are empty
            if(usernameTextbox.Text=="" || passwordTextBox.Text=="")
            {
                MessageBox.Show("Username or Password not entered, Please enter both and try again");
            }
            else
            {
                MobileClass mobileClass = new MobileClass();
                string sqlString = "select UserName,Password,LoginRole from LoginDetails where UserName='" + usernameTextbox.Text + "' and Password='" + passwordTextBox.Text + "'";
                DataTable mobileLoginTable = mobileClass.getTable(sqlString);
                if (mobileLoginTable.Rows.Count == 1)
                {
                    if (mobileLoginTable.Rows[0][2].ToString() == "Admin")
                    {
                        AdminAccount adminAccount = new AdminAccount();
                        adminAccount.Show();
                        this.Hide();
                    }
                    else if (mobileLoginTable.Rows[0][2].ToString()=="User")
                    {
                        UserAccount userAccount = new UserAccount();
                        userAccount.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please signup to register as user or Admin");
                    }
                }
                else
                {
                    MessageBox.Show("Entered UserId or Password is incorrect, Please type again.");
                }

                //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                //SqlConnection con = new SqlConnection(CS);
                //string sqlCommand = "select UserName,Password,LoginRole from LoginDetails where UserName='" + usernameTextbox.Text + "' and Password='" + passwordTextBox.Text+"'";
                //SqlDataAdapter da = new SqlDataAdapter(sqlCommand, con);
                //DataSet ds = new DataSet();
                //da.Fill(ds,"LoginTable");

                //if(ds.Tables["LoginTable"].Rows.Count==1)
                //{
                //    if(ds.Tables["LoginTable"].Rows[0][2].ToString()=="Admin")  //my 2nd column in database is role
                //    {
                //        label3.Text = "correct";
                //    }
                //}
            }
        }
    }
}
